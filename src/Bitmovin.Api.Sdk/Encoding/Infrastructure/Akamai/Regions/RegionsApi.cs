using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Akamai.Regions
{
    /// <summary>
    /// API for RegionsApi
    /// </summary>
    public class RegionsApi
    {
        private readonly IRegionsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the RegionsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public RegionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IRegionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of RegionsApi
        /// </summary>
        public static BitmovinApiBuilder<RegionsApi> Builder => new BitmovinApiBuilder<RegionsApi>();

        /// <summary>
        /// Add Akamai account region settings
        /// </summary>
        /// <param name="infrastructureId">Id of the Akamai account (required)</param>
        /// <param name="region">Akamai region (required)</param>
        /// <param name="akamaiAccountRegionSettings">The Akamai account region settings to be added</param>
        public async Task<Models.AkamaiAccountRegionSettings> CreateAsync(string infrastructureId, Models.AkamaiCloudRegion region, Models.AkamaiAccountRegionSettings akamaiAccountRegionSettings)
        {
            return await _apiClient.CreateAsync(infrastructureId, region, akamaiAccountRegionSettings);
        }

        /// <summary>
        /// Delete Akamai account region settings
        /// </summary>
        /// <param name="infrastructureId">Id of the Akamai account (required)</param>
        /// <param name="region">Akamai region (required)</param>
        public async Task<Models.AkamaiAccountRegionSettings> DeleteAsync(string infrastructureId, Models.AkamaiCloudRegion region)
        {
            return await _apiClient.DeleteAsync(infrastructureId, region);
        }

        /// <summary>
        /// Akamai account region settings details
        /// </summary>
        /// <param name="infrastructureId">Id of the Akamai account (required)</param>
        /// <param name="region">Akamai region (required)</param>
        public async Task<Models.AkamaiAccountRegionSettings> GetAsync(string infrastructureId, Models.AkamaiCloudRegion region)
        {
            return await _apiClient.GetAsync(infrastructureId, region);
        }

        /// <summary>
        /// List Akamai account region settings
        /// </summary>
        /// <param name="infrastructureId">Id of the Akamai account (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AkamaiAccountRegionSettings>> ListAsync(string infrastructureId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/infrastructure/akamai/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiAccountRegionSettings> CreateAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AkamaiCloudRegion region, [Body] Models.AkamaiAccountRegionSettings akamaiAccountRegionSettings);

            [Delete("/encoding/infrastructure/akamai/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiAccountRegionSettings> DeleteAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AkamaiCloudRegion region);

            [Get("/encoding/infrastructure/akamai/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiAccountRegionSettings> GetAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.AkamaiCloudRegion region);

            [Get("/encoding/infrastructure/akamai/{infrastructure_id}/regions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AkamaiAccountRegionSettings>> ListAsync([Path("infrastructure_id")] string infrastructureId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
