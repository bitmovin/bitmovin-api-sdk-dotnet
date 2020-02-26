using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Sftp.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Sftp
{
    public class SftpApi
    {
        private readonly ISftpApiClient _apiClient;

        public SftpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISftpApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SftpApi
        /// </summary>
        public static BitmovinApiBuilder<SftpApi> Builder => new BitmovinApiBuilder<SftpApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create SFTP Input
        /// </summary>
        /// <param name="sftpInput">The SFTP input to be created</param>
        public async Task<Models.SftpInput> CreateAsync(Models.SftpInput sftpInput)
        {
            return await _apiClient.CreateAsync(sftpInput);
        }

        /// <summary>
        /// Delete SFTP Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.SftpInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// SFTP Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.SftpInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List SFTP Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SftpInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface ISftpApiClient
        {
            [Post("/encoding/inputs/sftp")]
            [AllowAnyStatusCode]
            Task<Models.SftpInput> CreateAsync([Body] Models.SftpInput sftpInput);

            [Delete("/encoding/inputs/sftp/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.SftpInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/sftp/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.SftpInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/sftp")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SftpInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
