using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Dvbsub
{
    public class DvbsubApi
    {
        private readonly IDvbsubApiClient _apiClient;

        public DvbsubApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDvbsubApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DvbsubApi
        /// </summary>
        public static BitmovinApiBuilder<DvbsubApi> Builder => new BitmovinApiBuilder<DvbsubApi>();

        /// <summary>
        /// Burn-In DVB-SUB Subtitle into Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="burnInSubtitleDvbSub">The Burn-In DVB-SUB Subtitle to be added</param>
        public async Task<Models.BurnInSubtitleDvbSub> CreateAsync(string encodingId, string streamId, Models.BurnInSubtitleDvbSub burnInSubtitleDvbSub)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, burnInSubtitleDvbSub);
        }

        /// <summary>
        /// Delete Burn-In DVB-SUB Subtitle from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="subtitleId">Id of the subtitle. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, subtitleId);
        }

        /// <summary>
        /// Get Burn-In DVB-SUB Subtitle Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="subtitleId">Id of the subtitle. (required)</param>
        public async Task<Models.BurnInSubtitleDvbSub> GetAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, subtitleId);
        }

        /// <summary>
        /// List the Burn-In DVB-SUB subtitles of a stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.BurnInSubtitleDvbSub>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface IDvbsubApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/dvbsub")]
            [AllowAnyStatusCode]
            Task<Models.BurnInSubtitleDvbSub> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.BurnInSubtitleDvbSub burnInSubtitleDvbSub);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/dvbsub/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/dvbsub/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.BurnInSubtitleDvbSub> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/dvbsub")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.BurnInSubtitleDvbSub>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
