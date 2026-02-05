using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Type;
using Bitmovin.Api.Sdk.Encoding.Inputs.Rtmp;
using Bitmovin.Api.Sdk.Encoding.Inputs.RedundantRtmp;
using Bitmovin.Api.Sdk.Encoding.Inputs.S3;
using Bitmovin.Api.Sdk.Encoding.Inputs.S3RoleBased;
using Bitmovin.Api.Sdk.Encoding.Inputs.GenericS3;
using Bitmovin.Api.Sdk.Encoding.Inputs.Local;
using Bitmovin.Api.Sdk.Encoding.Inputs.Gcs;
using Bitmovin.Api.Sdk.Encoding.Inputs.GcsServiceAccount;
using Bitmovin.Api.Sdk.Encoding.Inputs.Azure;
using Bitmovin.Api.Sdk.Encoding.Inputs.Ftp;
using Bitmovin.Api.Sdk.Encoding.Inputs.Hls;
using Bitmovin.Api.Sdk.Encoding.Inputs.Sftp;
using Bitmovin.Api.Sdk.Encoding.Inputs.Http;
using Bitmovin.Api.Sdk.Encoding.Inputs.Https;
using Bitmovin.Api.Sdk.Encoding.Inputs.Aspera;
using Bitmovin.Api.Sdk.Encoding.Inputs.AkamaiNetstorage;
using Bitmovin.Api.Sdk.Encoding.Inputs.Srt;
using Bitmovin.Api.Sdk.Encoding.Inputs.Zixi;
using Bitmovin.Api.Sdk.Encoding.Inputs.DirectFileUpload;

namespace Bitmovin.Api.Sdk.Encoding.Inputs
{
    /// <summary>
    /// API for InputsApi
    /// </summary>
    public class InputsApi
    {
        private readonly IInputsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the InputsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public InputsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInputsApiClient>();
            Type = new TypeApi(apiClientFactory);
            Rtmp = new RtmpApi(apiClientFactory);
            RedundantRtmp = new RedundantRtmpApi(apiClientFactory);
            S3 = new S3Api(apiClientFactory);
            S3RoleBased = new S3RoleBasedApi(apiClientFactory);
            GenericS3 = new GenericS3Api(apiClientFactory);
            Local = new LocalApi(apiClientFactory);
            Gcs = new GcsApi(apiClientFactory);
            GcsServiceAccount = new GcsServiceAccountApi(apiClientFactory);
            Azure = new AzureApi(apiClientFactory);
            Ftp = new FtpApi(apiClientFactory);
            Hls = new HlsApi(apiClientFactory);
            Sftp = new SftpApi(apiClientFactory);
            Http = new HttpApi(apiClientFactory);
            Https = new HttpsApi(apiClientFactory);
            Aspera = new AsperaApi(apiClientFactory);
            AkamaiNetstorage = new AkamaiNetstorageApi(apiClientFactory);
            Srt = new SrtApi(apiClientFactory);
            Zixi = new ZixiApi(apiClientFactory);
            DirectFileUpload = new DirectFileUploadApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InputsApi
        /// </summary>
        public static BitmovinApiBuilder<InputsApi> Builder => new BitmovinApiBuilder<InputsApi>();

        /// <summary>
        /// Gets the Type API
        /// </summary>
        public TypeApi Type { get; }
        /// <summary>
        /// Gets the Rtmp API
        /// </summary>
        public RtmpApi Rtmp { get; }
        /// <summary>
        /// Gets the RedundantRtmp API
        /// </summary>
        public RedundantRtmpApi RedundantRtmp { get; }
        /// <summary>
        /// Gets the S3 API
        /// </summary>
        public S3Api S3 { get; }
        /// <summary>
        /// Gets the S3RoleBased API
        /// </summary>
        public S3RoleBasedApi S3RoleBased { get; }
        /// <summary>
        /// Gets the GenericS3 API
        /// </summary>
        public GenericS3Api GenericS3 { get; }
        /// <summary>
        /// Gets the Local API
        /// </summary>
        public LocalApi Local { get; }
        /// <summary>
        /// Gets the Gcs API
        /// </summary>
        public GcsApi Gcs { get; }
        /// <summary>
        /// Gets the GcsServiceAccount API
        /// </summary>
        public GcsServiceAccountApi GcsServiceAccount { get; }
        /// <summary>
        /// Gets the Azure API
        /// </summary>
        public AzureApi Azure { get; }
        /// <summary>
        /// Gets the Ftp API
        /// </summary>
        public FtpApi Ftp { get; }
        /// <summary>
        /// Gets the Hls API
        /// </summary>
        public HlsApi Hls { get; }
        /// <summary>
        /// Gets the Sftp API
        /// </summary>
        public SftpApi Sftp { get; }
        /// <summary>
        /// Gets the Http API
        /// </summary>
        public HttpApi Http { get; }
        /// <summary>
        /// Gets the Https API
        /// </summary>
        public HttpsApi Https { get; }
        /// <summary>
        /// Gets the Aspera API
        /// </summary>
        public AsperaApi Aspera { get; }
        /// <summary>
        /// Gets the AkamaiNetstorage API
        /// </summary>
        public AkamaiNetstorageApi AkamaiNetstorage { get; }
        /// <summary>
        /// Gets the Srt API
        /// </summary>
        public SrtApi Srt { get; }
        /// <summary>
        /// Gets the Zixi API
        /// </summary>
        public ZixiApi Zixi { get; }
        /// <summary>
        /// Gets the DirectFileUpload API
        /// </summary>
        public DirectFileUploadApi DirectFileUpload { get; }

        /// <summary>
        /// Get Input Details
        /// </summary>
        /// <param name="inputId">Id of the Input (required)</param>
        public async Task<Models.Input> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List all Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Input>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IInputsApiClient
        {
            [Get("/encoding/inputs/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.Input> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Input>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
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
            /// Filter inputs by name
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

            /// <summary>
            /// Filter inputs by type
            /// </summary>
            public ListQueryParams Type(string type) => SetQueryParam("type", type);

            /// <summary>
            /// Order list result according an input resource attribute.  The fields that can be used for sorting are: + &#x60;id&#x60; + &#x60;createdAt&#x60; + &#x60;modifiedAt&#x60; + &#x60;type&#x60; + &#x60;name&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

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
