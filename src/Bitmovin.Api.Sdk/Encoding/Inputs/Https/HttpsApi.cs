using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Https.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Https
{
    public class HttpsApi
    {
        private readonly IHttpsApiClient _apiClient;

        public HttpsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHttpsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of HttpsApi
        /// </summary>
        public static BitmovinApiBuilder<HttpsApi> Builder => new BitmovinApiBuilder<HttpsApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create HTTPS Input
        /// </summary>
        /// <param name="httpsInput">The Https input to be created</param>
        public async Task<Models.HttpsInput> CreateAsync(Models.HttpsInput httpsInput)
        {
            return await _apiClient.CreateAsync(httpsInput);
        }

        /// <summary>
        /// Delete HTTPS Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.HttpsInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// HTTPS Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.HttpsInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List HTTPS Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.HttpsInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IHttpsApiClient
        {
            [Post("/encoding/inputs/https")]
            [AllowAnyStatusCode]
            Task<Models.HttpsInput> CreateAsync([Body] Models.HttpsInput httpsInput);

            [Delete("/encoding/inputs/https/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.HttpsInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/https/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.HttpsInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/https")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.HttpsInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
