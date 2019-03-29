using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Video.Iframe
{
    public class IframeApi
    {
        private readonly IIframeApiClient _apiClient;

        public IframeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IIframeApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of IframeApi
        /// </summary>
        public static BitmovinApiBuilder<IframeApi> Builder => new BitmovinApiBuilder<IframeApi>();

        
        /// <summary>
        /// Add I-frame playlist to video media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest</param>
        /// <param name="mediaId">Id of the video media</param>
        /// <param name="iFramePlaylist">The request payload</param>
        public async Task<Models.IFramePlaylist> CreateAsync(string manifestId, string mediaId, Models.IFramePlaylist iFramePlaylist)
        {
            return await _apiClient.CreateAsync(manifestId, mediaId, iFramePlaylist);
        }
        
        /// <summary>
        /// Delete I-frame playlist
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest</param>
        /// <param name="mediaId">Id of the video media</param>
        /// <param name="iframeId">Id of the Iframe-Playlist</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string mediaId, string iframeId)
        {
            return await _apiClient.DeleteAsync(manifestId, mediaId, iframeId);
        }
        
        /// <summary>
        /// I-frame playlist Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest</param>
        /// <param name="mediaId">Id of the video media</param>
        /// <param name="iframeId">Id of the Iframe-Playlist</param>
        public async Task<Models.IFramePlaylist> GetAsync(string manifestId, string mediaId, string iframeId)
        {
            return await _apiClient.GetAsync(manifestId, mediaId, iframeId);
        }
        
        /// <summary>
        /// List all I-frame playlists of a video media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest</param>
        /// <param name="mediaId">Id of the video media</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.IFramePlaylist>> ListAsync(string manifestId, string mediaId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, mediaId, q);
        }
        
        internal interface IIframeApiClient
        {
            
            [Post("/encoding/manifests/hls/{manifest_id}/media/video/{media_id}/iframe")]
            [AllowAnyStatusCode]
            Task<Models.IFramePlaylist> CreateAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId, [Body] Models.IFramePlaylist iFramePlaylist);
            
            [Delete("/encoding/manifests/hls/{manifest_id}/media/video/{media_id}/iframe/{iframe_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId, [Path("iframe_id")] string iframeId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/media/video/{media_id}/iframe/{iframe_id}")]
            [AllowAnyStatusCode]
            Task<Models.IFramePlaylist> GetAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId, [Path("iframe_id")] string iframeId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/media/video/{media_id}/iframe")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.IFramePlaylist>> ListAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
