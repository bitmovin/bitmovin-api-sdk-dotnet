using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Azure.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Azure
{
    public class AzureApi
    {
        private readonly IAzureApiClient _apiClient;

        public AzureApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAzureApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AzureApi
        /// </summary>
        public static BitmovinApiBuilder<AzureApi> Builder => new BitmovinApiBuilder<AzureApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Azure Input
        /// </summary>
        /// <param name="azureInput">The Azure input to be created</param>
        public async Task<Models.AzureInput> CreateAsync(Models.AzureInput azureInput)
        {
            return await _apiClient.CreateAsync(azureInput);
        }

        /// <summary>
        /// Delete Azure Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.AzureInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// Azure Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.AzureInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List Azure Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AzureInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAzureApiClient
        {
            [Post("/encoding/inputs/azure")]
            [AllowAnyStatusCode]
            Task<Models.AzureInput> CreateAsync([Body] Models.AzureInput azureInput);

            [Delete("/encoding/inputs/azure/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.AzureInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/azure/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.AzureInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/azure")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AzureInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
