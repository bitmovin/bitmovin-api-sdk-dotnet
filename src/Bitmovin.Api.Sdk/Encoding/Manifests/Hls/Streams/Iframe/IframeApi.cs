using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Streams.Iframe
{
    /// <summary>
    /// API for IframeApi
    /// </summary>
    public class IframeApi
    {
        private readonly IIframeApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the IframeApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public IframeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IIframeApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of IframeApi
        /// </summary>
        public static BitmovinApiBuilder<IframeApi> Builder => new BitmovinApiBuilder<IframeApi>();

        /// <summary>
        /// Add I-frame playlist to variant stream
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="streamId">Id of the variant stream. (required)</param>
        /// <param name="iFramePlaylist">The I-frame playlist to be added</param>
        public async Task<Models.IFramePlaylist> CreateAsync(string manifestId, string streamId, Models.IFramePlaylist iFramePlaylist)
        {
            return await _apiClient.CreateAsync(manifestId, streamId, iFramePlaylist);
        }

        /// <summary>
        /// Delete I-frame playlist
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="streamId">Id of the variant stream. (required)</param>
        /// <param name="iframeId">Id of the Iframe-Playlist. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string streamId, string iframeId)
        {
            return await _apiClient.DeleteAsync(manifestId, streamId, iframeId);
        }

        /// <summary>
        /// I-frame playlist Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="streamId">Id of the variant stream. (required)</param>
        /// <param name="iframeId">Id of the Iframe-Playlist. (required)</param>
        public async Task<Models.IFramePlaylist> GetAsync(string manifestId, string streamId, string iframeId)
        {
            return await _apiClient.GetAsync(manifestId, streamId, iframeId);
        }

        /// <summary>
        /// List all I-frame playlists of a variant stream
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest. (required)</param>
        /// <param name="streamId">Id of the variant stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.IFramePlaylist>> ListAsync(string manifestId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, streamId, q);
        }

        internal interface IIframeApiClient
        {
            [Post("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}/iframe")]
            [AllowAnyStatusCode]
            Task<Models.IFramePlaylist> CreateAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId, [Body] Models.IFramePlaylist iFramePlaylist);

            [Delete("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}/iframe/{iframe_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId, [Path("iframe_id")] string iframeId);

            [Get("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}/iframe/{iframe_id}")]
            [AllowAnyStatusCode]
            Task<Models.IFramePlaylist> GetAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId, [Path("iframe_id")] string iframeId);

            [Get("/encoding/manifests/hls/{manifest_id}/streams/{stream_id}/iframe")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.IFramePlaylist>> ListAsync([Path("manifest_id")] string manifestId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
