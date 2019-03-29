using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.TimeBased
{
    public class TimeBasedApi
    {
        private readonly ITimeBasedApiClient _apiClient;

        public TimeBasedApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITimeBasedApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of TimeBasedApi
        /// </summary>
        public static BitmovinApiBuilder<TimeBasedApi> Builder => new BitmovinApiBuilder<TimeBasedApi>();

        
        /// <summary>
        /// Add Time-Based Trimming Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="timeBasedTrimmingInputStream">The request payload</param>
        public async Task<Models.TimeBasedTrimmingInputStream> CreateAsync(string encodingId, Models.TimeBasedTrimmingInputStream timeBasedTrimmingInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, timeBasedTrimmingInputStream);
        }
        
        /// <summary>
        /// Delete Time-Based Trimming Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the Time-Based Trimming Input Stream.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// Time-Based Trimming Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the Time-Based Trimming Input Stream.</param>
        public async Task<Models.TimeBasedTrimmingInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// List Time-Based Trimming Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TimeBasedTrimmingInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface ITimeBasedApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/input-streams/trimming/time-based")]
            [AllowAnyStatusCode]
            Task<Models.TimeBasedTrimmingInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.TimeBasedTrimmingInputStream timeBasedTrimmingInputStream);
            
            [Delete("/encoding/encodings/{encoding_id}/input-streams/trimming/time-based/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/trimming/time-based/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.TimeBasedTrimmingInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/trimming/time-based")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TimeBasedTrimmingInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
