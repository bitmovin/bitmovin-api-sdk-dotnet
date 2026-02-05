using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Oci.Regions
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
        /// Add OCI account region settings
        /// </summary>
        /// <param name="infrastructureId">Id of the OCI account (required)</param>
        /// <param name="region">OCI region (required)</param>
        /// <param name="ociAccountRegionSettings">The OCI account region settings to be added</param>
        public async Task<Models.OciAccountRegionSettings> CreateAsync(string infrastructureId, Models.OciCloudRegion region, Models.OciAccountRegionSettings ociAccountRegionSettings)
        {
            return await _apiClient.CreateAsync(infrastructureId, region, ociAccountRegionSettings);
        }

        /// <summary>
        /// Delete OCI account region settings
        /// </summary>
        /// <param name="infrastructureId">Id of the OCI account (required)</param>
        /// <param name="region">OCI region (required)</param>
        public async Task<Models.OciAccountRegionSettings> DeleteAsync(string infrastructureId, Models.OciCloudRegion region)
        {
            return await _apiClient.DeleteAsync(infrastructureId, region);
        }

        /// <summary>
        /// OCI account region settings details
        /// </summary>
        /// <param name="infrastructureId">Id of the OCI account (required)</param>
        /// <param name="region">OCI region (required)</param>
        public async Task<Models.OciAccountRegionSettings> GetAsync(string infrastructureId, Models.OciCloudRegion region)
        {
            return await _apiClient.GetAsync(infrastructureId, region);
        }

        /// <summary>
        /// List OCI account region settings
        /// </summary>
        /// <param name="infrastructureId">Id of the OCI account (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.OciAccountRegionSettings>> ListAsync(string infrastructureId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/infrastructure/oci/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.OciAccountRegionSettings> CreateAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.OciCloudRegion region, [Body] Models.OciAccountRegionSettings ociAccountRegionSettings);

            [Delete("/encoding/infrastructure/oci/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.OciAccountRegionSettings> DeleteAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.OciCloudRegion region);

            [Get("/encoding/infrastructure/oci/{infrastructure_id}/regions/{region}")]
            [AllowAnyStatusCode]
            Task<Models.OciAccountRegionSettings> GetAsync([Path("infrastructure_id")] string infrastructureId, [Path("region")] Models.OciCloudRegion region);

            [Get("/encoding/infrastructure/oci/{infrastructure_id}/regions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.OciAccountRegionSettings>> ListAsync([Path("infrastructure_id")] string infrastructureId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
