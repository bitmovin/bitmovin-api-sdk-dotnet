using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.ClosedCaptions
{
    /// <summary>
    /// API for ClosedCaptionsApi
    /// </summary>
    public class ClosedCaptionsApi
    {
        private readonly IClosedCaptionsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ClosedCaptionsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ClosedCaptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IClosedCaptionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ClosedCaptionsApi
        /// </summary>
        public static BitmovinApiBuilder<ClosedCaptionsApi> Builder => new BitmovinApiBuilder<ClosedCaptionsApi>();

        /// <summary>
        /// Add Closed Captions Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="closedCaptionsMediaInfo">The Closed Captions Media to be added</param>
        public async Task<Models.ClosedCaptionsMediaInfo> CreateAsync(string manifestId, Models.ClosedCaptionsMediaInfo closedCaptionsMediaInfo)
        {
            return await _apiClient.CreateAsync(manifestId, closedCaptionsMediaInfo);
        }

        /// <summary>
        /// Delete Closed Captions Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="mediaId">Id of the closed captions media. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string mediaId)
        {
            return await _apiClient.DeleteAsync(manifestId, mediaId);
        }

        /// <summary>
        /// Closed Captions Media Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="mediaId">Id of the closed captions media. (required)</param>
        public async Task<Models.ClosedCaptionsMediaInfo> GetAsync(string manifestId, string mediaId)
        {
            return await _apiClient.GetAsync(manifestId, mediaId);
        }

        /// <summary>
        /// List all Closed Captions Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ClosedCaptionsMediaInfo>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }

        internal interface IClosedCaptionsApiClient
        {
            [Post("/encoding/manifests/hls/{manifest_id}/media/closed-captions")]
            [AllowAnyStatusCode]
            Task<Models.ClosedCaptionsMediaInfo> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.ClosedCaptionsMediaInfo closedCaptionsMediaInfo);

            [Delete("/encoding/manifests/hls/{manifest_id}/media/closed-captions/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);

            [Get("/encoding/manifests/hls/{manifest_id}/media/closed-captions/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.ClosedCaptionsMediaInfo> GetAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);

            [Get("/encoding/manifests/hls/{manifest_id}/media/closed-captions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ClosedCaptionsMediaInfo>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
