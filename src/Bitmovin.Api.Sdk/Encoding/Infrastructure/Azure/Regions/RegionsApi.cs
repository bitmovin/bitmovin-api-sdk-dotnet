using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Azure.Regions
{
    public class RegionsApi
    {
        private readonly IRegionsApiClient _apiClient;

        public RegionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IRegionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of RegionsApi
        /// </summary>
        public static BitmovinApiBuilder<RegionsApi> Builder => new BitmovinApiBuilder<RegionsApi>();

        /// <summary>
        /// Add Azure Region Setting
        /// </summary>
        /// <param name="infrastructureId">Id of the Azure account (required)</param>
        /// <param name="region">Azure region. (required)</param>
        /// <param name="azureAccountRegionSettings">The Azure Region Settings to be added</param>
        public async Task<Models.AzureAccountRegionSettings> CreateAsync(string infrastructureId, Models.AzureCloudRegion region, Models.AzureAccountRegionSettings azureAccountRegionSettings)
        {
            return await _apiClient.CreateAsync(infrastructureId, region, azureAccountRegionSettings);
        }

        /// <summary>
        /// Delete Azure Region Settings
        /// </summary>
        /// <param name="infrastructureId">Id of the Azure account (required)</param>
        /// <param name="region">Azure region. (required)</param>
        public async Task<Models.AzureAccountRegionSettings> DeleteAsync(string infrastructureId, Models.AzureCloudRegion region)
        {
            return await _apiClient.DeleteAsync(infrastructureId, region);
        }

        /// <summary>
        /// Azure Region Settings Details
        /// </summary>
        /// <param name="infrastructureId">Id of the Azure account (required)</param>
        /// <param name="region">Azure region. (required)</param>
        public async Task<Models.AzureAccountRegionSettings> GetAsync(string infrastructureId, Models.AzureCloudRegion region)
        {
            return await _apiClient.GetAsync(infrastructureId, region);
        }

        /// <summary>
        /// List Azure Region Settings
        /// </summary>
        /// <param name="infrastructureId">Id of the Azure account (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AzureAccountRegionSettings>> ListAsync(string infrastructureId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(infrastructureId, q);
        }

        internal interface IRegionsApiClient
        {
            [Post("/encoding/infrastructure/azure/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AzureAccountRegionSettings> CreateAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AzureCloudRegion region, [Body] Models.AzureAccountRegionSettings azureAccountRegionSettings);

            [Delete("/encoding/infrastructure/azure/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AzureAccountRegionSettings> DeleteAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AzureCloudRegion region);

            [Get("/encoding/infrastructure/azure/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AzureAccountRegionSettings> GetAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AzureCloudRegion region);

            [Get("/encoding/infrastructure/azure/{infrastructure_id}/regions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AzureAccountRegionSettings>> ListAsync([Path("infrastructure_id")] string infrastructureId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
