using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.CustomTags
{
    public class CustomTagsApi
    {
        private readonly ICustomTagsApiClient _apiClient;

        public CustomTagsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomTagsApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomTagsApi
        /// </summary>
        public static BitmovinApiBuilder<CustomTagsApi> Builder => new BitmovinApiBuilder<CustomTagsApi>();

        
        /// <summary>
        /// Add Custom Tag to Audio Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="mediaId">Id of the audio media.</param>
        /// <param name="customTag">The request payload</param>
        public async Task<Models.CustomTag> CreateAsync(string manifestId, string mediaId, Models.CustomTag customTag)
        {
            return await _apiClient.CreateAsync(manifestId, mediaId, customTag);
        }
        
        /// <summary>
        /// Delete Custom Tag
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="mediaId">Id of the audio media.</param>
        /// <param name="customTagId">Id of the custom tag.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string mediaId, string customTagId)
        {
            return await _apiClient.DeleteAsync(manifestId, mediaId, customTagId);
        }
        
        /// <summary>
        /// Custom Tag Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="mediaId">Id of the audio media</param>
        /// <param name="customTagId">Id of the custom tag.</param>
        public async Task<Models.CustomTag> GetAsync(string manifestId, string mediaId, string customTagId)
        {
            return await _apiClient.GetAsync(manifestId, mediaId, customTagId);
        }
        
        /// <summary>
        /// List all Custom Tags of a Audio media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="mediaId">Id of the audio media.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CustomTag>> ListAsync(string manifestId, string mediaId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, mediaId, q);
        }
        
        internal interface ICustomTagsApiClient
        {
            
            [Post("/encoding/manifests/hls/{manifest_id}/media/{media_id}/custom-tags")]
            [AllowAnyStatusCode]
            Task<Models.CustomTag> CreateAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId, [Body] Models.CustomTag customTag);
            
            [Delete("/encoding/manifests/hls/{manifest_id}/media/{media_id}/custom-tags/{custom_tag_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId, [Path("custom_tag_id")] string customTagId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/media/{media_id}/custom-tags/{custom_tag_id}")]
            [AllowAnyStatusCode]
            Task<Models.CustomTag> GetAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId, [Path("custom_tag_id")] string customTagId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/media/{media_id}/custom-tags")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CustomTag>> ListAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId, [QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

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
