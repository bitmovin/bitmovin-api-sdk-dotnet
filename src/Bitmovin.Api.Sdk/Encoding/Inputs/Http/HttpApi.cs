using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Http.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Http
{
    public class HttpApi
    {
        private readonly IHttpApiClient _apiClient;

        public HttpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHttpApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of HttpApi
        /// </summary>
        public static BitmovinApiBuilder<HttpApi> Builder => new BitmovinApiBuilder<HttpApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create HTTP Input
        /// </summary>
        /// <param name="httpInput">The HTTP input to be created</param>
        public async Task<Models.HttpInput> CreateAsync(Models.HttpInput httpInput)
        {
            return await _apiClient.CreateAsync(httpInput);
        }

        /// <summary>
        /// Delete HTTP Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.HttpInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// HTTP Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.HttpInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List HTTP Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.HttpInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IHttpApiClient
        {
            [Post("/encoding/inputs/http")]
            [AllowAnyStatusCode]
            Task<Models.HttpInput> CreateAsync([Body] Models.HttpInput httpInput);

            [Delete("/encoding/inputs/http/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.HttpInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/http/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.HttpInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/http")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.HttpInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
