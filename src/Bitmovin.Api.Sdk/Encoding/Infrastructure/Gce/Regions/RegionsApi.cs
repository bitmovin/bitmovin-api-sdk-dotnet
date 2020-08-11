using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Gce.Regions
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
        /// Add Google Cloud Region Setting
        /// </summary>
        /// <param name="infrastructureId">Id of the Google Cloud Connect infrastructure resource (required)</param>
        /// <param name="region">Google Cloud Region. (required)</param>
        /// <param name="gceAccountRegionSettings">The Google Cloud Region Settings to be added</param>
        public async Task<Models.GceAccountRegionSettings> CreateAsync(string infrastructureId, Models.GoogleCloudRegion region, Models.GceAccountRegionSettings gceAccountRegionSettings)
        {
            return await _apiClient.CreateAsync(infrastructureId, region, gceAccountRegionSettings);
        }

        /// <summary>
        /// Delete Google Cloud Region Settings
        /// </summary>
        /// <param name="infrastructureId">Id of the Google Cloud Connect infrastructure resource (required)</param>
        /// <param name="region">Google Cloud Region (required)</param>
        public async Task<Models.GceAccountRegionSettings> DeleteAsync(string infrastructureId, Models.GoogleCloudRegion region)
        {
            return await _apiClient.DeleteAsync(infrastructureId, region);
        }

        /// <summary>
        /// Google Cloud Region Settings Details
        /// </summary>
        /// <param name="infrastructureId">Id of the Google Cloud Connect infrastructure resource (required)</param>
        /// <param name="region">Google Cloud region. (required)</param>
        public async Task<Models.GceAccountRegionSettings> GetAsync(string infrastructureId, Models.GoogleCloudRegion region)
        {
            return await _apiClient.GetAsync(infrastructureId, region);
        }

        /// <summary>
        /// List Google Cloud Region Settings
        /// </summary>
        /// <param name="infrastructureId">Id of the Google Cloud Connect infrastructure resource (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.GceAccountRegionSettings>> ListAsync(string infrastructureId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/infrastructure/gce/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.GceAccountRegionSettings> CreateAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.GoogleCloudRegion region, [Body] Models.GceAccountRegionSettings gceAccountRegionSettings);

            [Delete("/encoding/infrastructure/gce/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.GceAccountRegionSettings> DeleteAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.GoogleCloudRegion region);

            [Get("/encoding/infrastructure/gce/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.GceAccountRegionSettings> GetAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.GoogleCloudRegion region);

            [Get("/encoding/infrastructure/gce/{infrastructure_id}/regions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.GceAccountRegionSettings>> ListAsync([Path("infrastructure_id")] string infrastructureId, [QueryMap] IDictionary<String, Object> queryParams);
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
