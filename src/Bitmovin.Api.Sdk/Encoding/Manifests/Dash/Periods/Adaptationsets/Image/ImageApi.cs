using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Image
{
    /// <summary>
    /// API for ImageApi
    /// </summary>
    public class ImageApi
    {
        private readonly IImageApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ImageApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ImageApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IImageApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ImageApi
        /// </summary>
        public static BitmovinApiBuilder<ImageApi> Builder => new BitmovinApiBuilder<ImageApi>();

        /// <summary>
        /// Add Image AdaptationSet
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="imageAdaptationSet">The image adaptation set to be added to the period</param>
        public async Task<Models.ImageAdaptationSet> CreateAsync(string manifestId, string periodId, Models.ImageAdaptationSet imageAdaptationSet)
        {
            return await _apiClient.CreateAsync(manifestId, periodId, imageAdaptationSet);
        }

        /// <summary>
        /// Delete Image AdaptationSet
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the audio adaptation set to be deleted (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string periodId, string adaptationsetId)
        {
            return await _apiClient.DeleteAsync(manifestId, periodId, adaptationsetId);
        }

        /// <summary>
        /// Image AdaptationSet Details
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the Image adaptation set (required)</param>
        public async Task<Models.ImageAdaptationSet> GetAsync(string manifestId, string periodId, string adaptationsetId)
        {
            return await _apiClient.GetAsync(manifestId, periodId, adaptationsetId);
        }

        /// <summary>
        /// List all Image AdaptationSets
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ImageAdaptationSet>> ListAsync(string manifestId, string periodId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, q);
        }

        internal interface IImageApiClient
        {
            [Post("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/image")]
            [AllowAnyStatusCode]
            Task<Models.ImageAdaptationSet> CreateAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Body] Models.ImageAdaptationSet imageAdaptationSet);

            [Delete("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/image/{adaptationset_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/image/{adaptationset_id}")]
            [AllowAnyStatusCode]
            Task<Models.ImageAdaptationSet> GetAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId);

            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/image")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ImageAdaptationSet>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
