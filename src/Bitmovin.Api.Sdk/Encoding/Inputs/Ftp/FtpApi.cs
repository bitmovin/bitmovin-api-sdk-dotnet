using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Ftp.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Ftp
{
    public class FtpApi
    {
        private readonly IFtpApiClient _apiClient;

        public FtpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFtpApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of FtpApi
        /// </summary>
        public static BitmovinApiBuilder<FtpApi> Builder => new BitmovinApiBuilder<FtpApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create FTP Input
        /// </summary>
        /// <param name="ftpInput">The FTP input to be created</param>
        public async Task<Models.FtpInput> CreateAsync(Models.FtpInput ftpInput)
        {
            return await _apiClient.CreateAsync(ftpInput);
        }

        /// <summary>
        /// Delete FTP Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.FtpInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// FTP Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.FtpInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List FTP Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.FtpInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IFtpApiClient
        {
            [Post("/encoding/inputs/ftp")]
            [AllowAnyStatusCode]
            Task<Models.FtpInput> CreateAsync([Body] Models.FtpInput ftpInput);

            [Delete("/encoding/inputs/ftp/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.FtpInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/ftp/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.FtpInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/ftp")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.FtpInput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Filter inputs by name
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

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
