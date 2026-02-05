using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Azure.Regions;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Azure
{
    /// <summary>
    /// API for AzureApi
    /// </summary>
    public class AzureApi
    {
        private readonly IAzureApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AzureApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AzureApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAzureApiClient>();
            Regions = new RegionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AzureApi
        /// </summary>
        public static BitmovinApiBuilder<AzureApi> Builder => new BitmovinApiBuilder<AzureApi>();

        /// <summary>
        /// Gets the Regions API
        /// </summary>
        public RegionsApi Regions { get; }

        /// <summary>
        /// Add Azure Account
        /// </summary>
        /// <param name="azureAccount">The Azure Account to be added</param>
        public async Task<Models.AzureAccount> CreateAsync(Models.AzureAccount azureAccount)
        {
            return await _apiClient.CreateAsync(azureAccount);
        }

        /// <summary>
        /// Delete Azure Account
        /// </summary>
        /// <param name="infrastructureId">Id of the Azure account (required)</param>
        public async Task<Models.AzureAccount> DeleteAsync(string infrastructureId)
        {
            return await _apiClient.DeleteAsync(infrastructureId);
        }

        /// <summary>
        /// Azure Account Details
        /// </summary>
        /// <param name="infrastructureId">Id of the Azure account (required)</param>
        public async Task<Models.AzureAccount> GetAsync(string infrastructureId)
        {
            return await _apiClient.GetAsync(infrastructureId);
        }

        /// <summary>
        /// List Azure Accounts
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AzureAccount>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/infrastructure/azure")]
            [AllowAnyStatusCode]
            Task<Models.AzureAccount> CreateAsync([Body] Models.AzureAccount azureAccount);

            [Delete("/encoding/infrastructure/azure/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.AzureAccount> DeleteAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/azure/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.AzureAccount> GetAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/azure")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AzureAccount>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
