using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.TimecodeTrack
{
    public class TimecodeTrackApi
    {
        private readonly ITimecodeTrackApiClient _apiClient;

        public TimecodeTrackApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITimecodeTrackApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TimecodeTrackApi
        /// </summary>
        public static BitmovinApiBuilder<TimecodeTrackApi> Builder => new BitmovinApiBuilder<TimecodeTrackApi>();

        /// <summary>
        /// Add Timecode Track Trimming Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="timecodeTrackTrimmingInputStream">The Timecode Track Trimming Input Stream to be created</param>
        public async Task<Models.TimecodeTrackTrimmingInputStream> CreateAsync(string encodingId, Models.TimecodeTrackTrimmingInputStream timecodeTrackTrimmingInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, timecodeTrackTrimmingInputStream);
        }

        /// <summary>
        /// Delete Timecode Track Trimming Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the Timecode Track Trimming Input Stream. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// Timecode Track Trimming Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the Timecode Track Trimming Input Stream. (required)</param>
        public async Task<Models.TimecodeTrackTrimmingInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List Timecode Track Trimming Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TimecodeTrackTrimmingInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface ITimecodeTrackApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/trimming/timecode-track")]
            [AllowAnyStatusCode]
            Task<Models.TimecodeTrackTrimmingInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.TimecodeTrackTrimmingInputStream timecodeTrackTrimmingInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/trimming/timecode-track/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/trimming/timecode-track/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.TimecodeTrackTrimmingInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/trimming/timecode-track")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TimecodeTrackTrimmingInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
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
