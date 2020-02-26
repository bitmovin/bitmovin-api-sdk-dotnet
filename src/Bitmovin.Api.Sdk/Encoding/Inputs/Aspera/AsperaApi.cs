using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Aspera.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Aspera
{
    public class AsperaApi
    {
        private readonly IAsperaApiClient _apiClient;

        public AsperaApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAsperaApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AsperaApi
        /// </summary>
        public static BitmovinApiBuilder<AsperaApi> Builder => new BitmovinApiBuilder<AsperaApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Aspera Input
        /// </summary>
        /// <param name="asperaInput">The Aspera input to be created</param>
        public async Task<Models.AsperaInput> CreateAsync(Models.AsperaInput asperaInput)
        {
            return await _apiClient.CreateAsync(asperaInput);
        }

        /// <summary>
        /// Delete Aspera Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.AsperaInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// Aspera Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.AsperaInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List Aspera Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AsperaInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAsperaApiClient
        {
            [Post("/encoding/inputs/aspera")]
            [AllowAnyStatusCode]
            Task<Models.AsperaInput> CreateAsync([Body] Models.AsperaInput asperaInput);

            [Delete("/encoding/inputs/aspera/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.AsperaInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/aspera/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.AsperaInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/aspera")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AsperaInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
