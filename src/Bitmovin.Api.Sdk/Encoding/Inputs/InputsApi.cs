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
using Bitmovin.Api.Sdk.Encoding.Inputs.Azure;
using Bitmovin.Api.Sdk.Encoding.Inputs.Ftp;
using Bitmovin.Api.Sdk.Encoding.Inputs.Sftp;
using Bitmovin.Api.Sdk.Encoding.Inputs.Http;
using Bitmovin.Api.Sdk.Encoding.Inputs.Https;
using Bitmovin.Api.Sdk.Encoding.Inputs.Aspera;
using Bitmovin.Api.Sdk.Encoding.Inputs.AkamaiNetstorage;
using Bitmovin.Api.Sdk.Encoding.Inputs.Srt;
using Bitmovin.Api.Sdk.Encoding.Inputs.Tcp;
using Bitmovin.Api.Sdk.Encoding.Inputs.Udp;
using Bitmovin.Api.Sdk.Encoding.Inputs.UdpMulticast;
using Bitmovin.Api.Sdk.Encoding.Inputs.Zixi;

namespace Bitmovin.Api.Sdk.Encoding.Inputs
{
    public class InputsApi
    {
        private readonly IInputsApiClient _apiClient;

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
            Azure = new AzureApi(apiClientFactory);
            Ftp = new FtpApi(apiClientFactory);
            Sftp = new SftpApi(apiClientFactory);
            Http = new HttpApi(apiClientFactory);
            Https = new HttpsApi(apiClientFactory);
            Aspera = new AsperaApi(apiClientFactory);
            AkamaiNetstorage = new AkamaiNetstorageApi(apiClientFactory);
            Srt = new SrtApi(apiClientFactory);
            Tcp = new TcpApi(apiClientFactory);
            Udp = new UdpApi(apiClientFactory);
            UdpMulticast = new UdpMulticastApi(apiClientFactory);
            Zixi = new ZixiApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InputsApi
        /// </summary>
        public static BitmovinApiBuilder<InputsApi> Builder => new BitmovinApiBuilder<InputsApi>();

        public TypeApi Type { get; private set; }
        public RtmpApi Rtmp { get; private set; }
        public RedundantRtmpApi RedundantRtmp { get; private set; }
        public S3Api S3 { get; private set; }
        public S3RoleBasedApi S3RoleBased { get; private set; }
        public GenericS3Api GenericS3 { get; private set; }
        public LocalApi Local { get; private set; }
        public GcsApi Gcs { get; private set; }
        public AzureApi Azure { get; private set; }
        public FtpApi Ftp { get; private set; }
        public SftpApi Sftp { get; private set; }
        public HttpApi Http { get; private set; }
        public HttpsApi Https { get; private set; }
        public AsperaApi Aspera { get; private set; }
        public AkamaiNetstorageApi AkamaiNetstorage { get; private set; }
        public SrtApi Srt { get; private set; }
        public TcpApi Tcp { get; private set; }
        public UdpApi Udp { get; private set; }
        public UdpMulticastApi UdpMulticast { get; private set; }
        public ZixiApi Zixi { get; private set; }
        
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
            
            [Get("/encoding/inputs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Input>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
            /// Filter inputs by name
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
