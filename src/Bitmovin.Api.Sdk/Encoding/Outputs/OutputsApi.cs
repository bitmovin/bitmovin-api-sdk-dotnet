using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.Type;
using Bitmovin.Api.Sdk.Encoding.Outputs.S3;
using Bitmovin.Api.Sdk.Encoding.Outputs.S3RoleBased;
using Bitmovin.Api.Sdk.Encoding.Outputs.GenericS3;
using Bitmovin.Api.Sdk.Encoding.Outputs.Local;
using Bitmovin.Api.Sdk.Encoding.Outputs.Gcs;
using Bitmovin.Api.Sdk.Encoding.Outputs.GcsServiceAccount;
using Bitmovin.Api.Sdk.Encoding.Outputs.Azure;
using Bitmovin.Api.Sdk.Encoding.Outputs.Ftp;
using Bitmovin.Api.Sdk.Encoding.Outputs.Sftp;
using Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiMsl;
using Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiNetstorage;
using Bitmovin.Api.Sdk.Encoding.Outputs.LiveMediaIngest;
using Bitmovin.Api.Sdk.Encoding.Outputs.Cdn;

namespace Bitmovin.Api.Sdk.Encoding.Outputs
{
    public class OutputsApi
    {
        private readonly IOutputsApiClient _apiClient;

        public OutputsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IOutputsApiClient>();
            Type = new TypeApi(apiClientFactory);
            S3 = new S3Api(apiClientFactory);
            S3RoleBased = new S3RoleBasedApi(apiClientFactory);
            GenericS3 = new GenericS3Api(apiClientFactory);
            Local = new LocalApi(apiClientFactory);
            Gcs = new GcsApi(apiClientFactory);
            GcsServiceAccount = new GcsServiceAccountApi(apiClientFactory);
            Azure = new AzureApi(apiClientFactory);
            Ftp = new FtpApi(apiClientFactory);
            Sftp = new SftpApi(apiClientFactory);
            AkamaiMsl = new AkamaiMslApi(apiClientFactory);
            AkamaiNetstorage = new AkamaiNetstorageApi(apiClientFactory);
            LiveMediaIngest = new LiveMediaIngestApi(apiClientFactory);
            Cdn = new CdnApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OutputsApi
        /// </summary>
        public static BitmovinApiBuilder<OutputsApi> Builder => new BitmovinApiBuilder<OutputsApi>();

        public TypeApi Type { get; }
        public S3Api S3 { get; }
        public S3RoleBasedApi S3RoleBased { get; }
        public GenericS3Api GenericS3 { get; }
        public LocalApi Local { get; }
        public GcsApi Gcs { get; }
        public GcsServiceAccountApi GcsServiceAccount { get; }
        public AzureApi Azure { get; }
        public FtpApi Ftp { get; }
        public SftpApi Sftp { get; }
        public AkamaiMslApi AkamaiMsl { get; }
        public AkamaiNetstorageApi AkamaiNetstorage { get; }
        public LiveMediaIngestApi LiveMediaIngest { get; }
        public CdnApi Cdn { get; }

        /// <summary>
        /// Check output permissions (S3 only)
        /// </summary>
        /// <param name="outputId">Id of the output to be checked. Currently limited to S3 outputs. The access credentials that have been provided for this Output still need to be valid, otherwise the request will fail. If they are not valid any more, create a new Output with new credentials (resources are immutable). (required)</param>
        /// <param name="checkOutputPermissionsRequest">Additional parameters for the permissions check</param>
        public async Task<Models.CheckOutputPermissionsResponse> CheckPermissionsAsync(string outputId, Models.CheckOutputPermissionsRequest checkOutputPermissionsRequest = null)
        {
            return await _apiClient.CheckPermissionsAsync(outputId, checkOutputPermissionsRequest);
        }

        /// <summary>
        /// Get Output Details
        /// </summary>
        /// <param name="outputId">Id of the wanted output (required)</param>
        public async Task<Models.Output> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List all Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Output>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IOutputsApiClient
        {
            [Post("/encoding/outputs/{output_id}/check-permissions")]
            [AllowAnyStatusCode]
            Task<Models.CheckOutputPermissionsResponse> CheckPermissionsAsync([Path("output_id")] string outputId, [Body] Models.CheckOutputPermissionsRequest checkOutputPermissionsRequest);

            [Get("/encoding/outputs/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.Output> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Output>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            /// <summary>
            /// Filter outputs by name
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

            /// <summary>
            /// Order list result according to a output resource attribute. The fields that can be used for sorting are: + &#x60;id&#x60; + &#x60;createdAt&#x60; + &#x60;modifiedAt&#x60; + &#x60;type&#x60; + &#x60;name&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Filter outputs by type
            /// </summary>
            public ListQueryParams Type(Models.OutputType type) => SetQueryParam("type", type);

            private ListQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}
