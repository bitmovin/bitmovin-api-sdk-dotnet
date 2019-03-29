using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Streams.CustomTag
{
    public class CustomTagApi
    {
        private readonly ICustomTagApiClient _apiClient;

        public CustomTagApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomTagApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomTagApi
        /// </summary>
        public static BitmovinApiBuilder<CustomTagApi> Builder => new BitmovinApiBuilder<CustomTagApi>();

        
        /// <summary>
        /// Add Custom Tag to Variant Stream
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="streamId">Id of the variant stream.</param>
        /// <param name="customTag">The request payload</param>
        public async Task<Models.CustomTag> CreateAsync(string manifestId, string streamId, Models.CustomTag customTag)
        {
            return await _apiClient.CreateAsync(manifestId, streamId, customTag);
        }
        
        /// <summary>
        /// Delete Custom Tag
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="streamId">Id of the variant stream.</param>
        /// <param name="customTagId">Id of the custom tag.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string streamId, string customTagId)
        {
            return await _apiClient.DeleteAsync(manifestId, streamId, customTagId);
        }
        
        /// <summary>
        /// Custom Tag Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="streamId">Id of the variant stream.</param>
        /// <param name="customTagId">Id of the custom tag.</param>
        public async Task<Models.CustomTag> GetAsync(string manifestId, string streamId, string customTagId)
        {
            return await _apiClient.GetAsync(manifestId, streamId, customTagId);
        }
        
        /// <summary>
        /// List all Custom Tags of a Variant Stream
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="streamId">Id of the variant stream.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CustomTag>> ListAsync(string manifestId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, streamId, q);
        }
        
        internal interface ICustomTagApiClient
        {
            
            [Post("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}/custom-tag")]
            [AllowAnyStatusCode]
            Task<Models.CustomTag> CreateAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId, [Body] Models.CustomTag customTag);
            
            [Delete("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}/custom-tag/{custom_tag_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId, [Path("custom_tag_id")] string customTagId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}/custom-tag/{custom_tag_id}")]
            [AllowAnyStatusCode]
            Task<Models.CustomTag> GetAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId, [Path("custom_tag_id")] string customTagId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}/custom-tag")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CustomTag>> ListAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
