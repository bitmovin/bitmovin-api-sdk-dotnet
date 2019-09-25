using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Srt
{
    public class SrtApi
    {
        private readonly ISrtApiClient _apiClient;

        public SrtApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISrtApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of SrtApi
        /// </summary>
        public static BitmovinApiBuilder<SrtApi> Builder => new BitmovinApiBuilder<SrtApi>();

        
        /// <summary>
        /// Burn-In SRT Subtitle into Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="burnInSubtitleSrt">The request payload</param>
        public async Task<Models.BurnInSubtitleSrt> CreateAsync(string encodingId, string streamId, Models.BurnInSubtitleSrt burnInSubtitleSrt)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, burnInSubtitleSrt);
        }
        
        /// <summary>
        /// Delete Burn-In SRT Subtitle from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="subtitleId">Id of the burn-in subtitle.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, subtitleId);
        }
        
        /// <summary>
        /// Get Burn-In SRT Subtitle Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="subtitleId">Id of the burn-in subtitle.</param>
        public async Task<Models.BurnInSubtitleSrt> GetAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, subtitleId);
        }
        
        /// <summary>
        /// List the Burn-In SRT subtitles of a stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.BurnInSubtitleSrt>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }
        
        internal interface ISrtApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/srt")]
            [AllowAnyStatusCode]
            Task<Models.BurnInSubtitleSrt> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.BurnInSubtitleSrt burnInSubtitleSrt);
            
            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/srt/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/srt/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.BurnInSubtitleSrt> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/srt")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.BurnInSubtitleSrt>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
