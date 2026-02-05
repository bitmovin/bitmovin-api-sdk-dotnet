using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Assa
{
    /// <summary>
    /// API for AssaApi
    /// </summary>
    public class AssaApi
    {
        private readonly IAssaApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AssaApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AssaApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAssaApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of AssaApi
        /// </summary>
        public static BitmovinApiBuilder<AssaApi> Builder => new BitmovinApiBuilder<AssaApi>();

        /// <summary>
        /// Burn-In ASSA Subtitle into Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="burnInSubtitleAssa">The Burn-In ASSA Subtitle to be added</param>
        public async Task<Models.BurnInSubtitleAssa> CreateAsync(string encodingId, string streamId, Models.BurnInSubtitleAssa burnInSubtitleAssa)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, burnInSubtitleAssa);
        }

        /// <summary>
        /// Delete Burn-In ASSA Subtitle from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="subtitleId">Id of the burn-in subtitle. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, subtitleId);
        }

        /// <summary>
        /// Get Burn-In ASSA Subtitle Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="subtitleId">Id of the burn-in subtitle. (required)</param>
        public async Task<Models.BurnInSubtitleAssa> GetAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, subtitleId);
        }

        /// <summary>
        /// List the Burn-In ASSA subtitles of a stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.BurnInSubtitleAssa>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface IAssaApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/assa")]
            [AllowAnyStatusCode]
            Task<Models.BurnInSubtitleAssa> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.BurnInSubtitleAssa burnInSubtitleAssa);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/assa/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/assa/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.BurnInSubtitleAssa> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/assa")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.BurnInSubtitleAssa>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
