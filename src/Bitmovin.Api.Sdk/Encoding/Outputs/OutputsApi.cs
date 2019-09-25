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
using Bitmovin.Api.Sdk.Encoding.Outputs.Azure;
using Bitmovin.Api.Sdk.Encoding.Outputs.Ftp;
using Bitmovin.Api.Sdk.Encoding.Outputs.Sftp;
using Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiMsl;
using Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiNetstorage;
using Bitmovin.Api.Sdk.Encoding.Outputs.LiveMediaIngest;

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
            Azure = new AzureApi(apiClientFactory);
            Ftp = new FtpApi(apiClientFactory);
            Sftp = new SftpApi(apiClientFactory);
            AkamaiMsl = new AkamaiMslApi(apiClientFactory);
            AkamaiNetstorage = new AkamaiNetstorageApi(apiClientFactory);
            LiveMediaIngest = new LiveMediaIngestApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OutputsApi
        /// </summary>
        public static BitmovinApiBuilder<OutputsApi> Builder => new BitmovinApiBuilder<OutputsApi>();

        public TypeApi Type { get; private set; }
        public S3Api S3 { get; private set; }
        public S3RoleBasedApi S3RoleBased { get; private set; }
        public GenericS3Api GenericS3 { get; private set; }
        public LocalApi Local { get; private set; }
        public GcsApi Gcs { get; private set; }
        public AzureApi Azure { get; private set; }
        public FtpApi Ftp { get; private set; }
        public SftpApi Sftp { get; private set; }
        public AkamaiMslApi AkamaiMsl { get; private set; }
        public AkamaiNetstorageApi AkamaiNetstorage { get; private set; }
        public LiveMediaIngestApi LiveMediaIngest { get; private set; }
        
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
            
            [Get("/encoding/outputs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Output>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

            /// <summary>
            /// Filter output by name
            /// </summary>
            public ListQueryParams Name(string Name) => SetQueryParam("name", Name);

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
