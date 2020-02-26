using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Subtitles
{
    public class SubtitlesApi
    {
        private readonly ISubtitlesApiClient _apiClient;

        public SubtitlesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISubtitlesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of SubtitlesApi
        /// </summary>
        public static BitmovinApiBuilder<SubtitlesApi> Builder => new BitmovinApiBuilder<SubtitlesApi>();

        /// <summary>
        /// Add Subtitles Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="subtitlesMediaInfo">The Subtitles Media to be added</param>
        public async Task<Models.SubtitlesMediaInfo> CreateAsync(string manifestId, Models.SubtitlesMediaInfo subtitlesMediaInfo)
        {
            return await _apiClient.CreateAsync(manifestId, subtitlesMediaInfo);
        }

        /// <summary>
        /// Delete Subtitles Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="mediaId">Id of the subtitles media. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string mediaId)
        {
            return await _apiClient.DeleteAsync(manifestId, mediaId);
        }

        /// <summary>
        /// Subtitles Media Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="mediaId">Id of the subtitles media. (required)</param>
        public async Task<Models.SubtitlesMediaInfo> GetAsync(string manifestId, string mediaId)
        {
            return await _apiClient.GetAsync(manifestId, mediaId);
        }

        /// <summary>
        /// List all Subtitles Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SubtitlesMediaInfo>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }

        internal interface ISubtitlesApiClient
        {
            [Post("/encoding/manifests/hls/{manifest_id}/media/subtitles")]
            [AllowAnyStatusCode]
            Task<Models.SubtitlesMediaInfo> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.SubtitlesMediaInfo subtitlesMediaInfo);

            [Delete("/encoding/manifests/hls/{manifest_id}/media/subtitles/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);

            [Get("/encoding/manifests/hls/{manifest_id}/media/subtitles/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.SubtitlesMediaInfo> GetAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);

            [Get("/encoding/manifests/hls/{manifest_id}/media/subtitles")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SubtitlesMediaInfo>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap] IDictionary<String, Object> queryParams);
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
