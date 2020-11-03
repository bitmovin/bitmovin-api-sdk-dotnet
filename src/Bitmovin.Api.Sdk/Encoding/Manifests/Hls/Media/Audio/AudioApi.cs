using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Audio
{
    public class AudioApi
    {
        private readonly IAudioApiClient _apiClient;

        public AudioApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAudioApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of AudioApi
        /// </summary>
        public static BitmovinApiBuilder<AudioApi> Builder => new BitmovinApiBuilder<AudioApi>();

        /// <summary>
        /// Add Audio Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="audioMediaInfo">The Audio Media to be added</param>
        public async Task<Models.AudioMediaInfo> CreateAsync(string manifestId, Models.AudioMediaInfo audioMediaInfo)
        {
            return await _apiClient.CreateAsync(manifestId, audioMediaInfo);
        }

        /// <summary>
        /// Delete Audio Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="mediaId">Id of the audio media. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string mediaId)
        {
            return await _apiClient.DeleteAsync(manifestId, mediaId);
        }

        /// <summary>
        /// Audio Media Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="mediaId">Id of the audio media. (required)</param>
        public async Task<Models.AudioMediaInfo> GetAsync(string manifestId, string mediaId)
        {
            return await _apiClient.GetAsync(manifestId, mediaId);
        }

        /// <summary>
        /// List all Audio Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AudioMediaInfo>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }

        internal interface IAudioApiClient
        {
            [Post("/encoding/manifests/hls/{manifest_id}/media/audio")]
            [AllowAnyStatusCode]
            Task<Models.AudioMediaInfo> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.AudioMediaInfo audioMediaInfo);

            [Delete("/encoding/manifests/hls/{manifest_id}/media/audio/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);

            [Get("/encoding/manifests/hls/{manifest_id}/media/audio/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.AudioMediaInfo> GetAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);

            [Get("/encoding/manifests/hls/{manifest_id}/media/audio")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AudioMediaInfo>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
