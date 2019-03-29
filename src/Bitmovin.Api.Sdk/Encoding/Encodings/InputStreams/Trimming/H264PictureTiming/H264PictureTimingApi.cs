using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.H264PictureTiming
{
    public class H264PictureTimingApi
    {
        private readonly IH264PictureTimingApiClient _apiClient;

        public H264PictureTimingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IH264PictureTimingApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of H264PictureTimingApi
        /// </summary>
        public static BitmovinApiBuilder<H264PictureTimingApi> Builder => new BitmovinApiBuilder<H264PictureTimingApi>();

        
        /// <summary>
        /// Add H264 Picture Timing Trimming Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="h264PictureTimingTrimmingInputStream">The request payload</param>
        public async Task<Models.H264PictureTimingTrimmingInputStream> CreateAsync(string encodingId, Models.H264PictureTimingTrimmingInputStream h264PictureTimingTrimmingInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, h264PictureTimingTrimmingInputStream);
        }
        
        /// <summary>
        /// Delete H264 Picture Timing Trimming Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the H264 Picture Timing Trimming Input Stream.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// H264 Picture Timing Trimming Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the H264 Picture Timing Trimming Input Stream.</param>
        public async Task<Models.H264PictureTimingTrimmingInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// List H264 Picture Timing Trimming Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.H264PictureTimingTrimmingInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IH264PictureTimingApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/input-streams/trimming/h264-picture-timing")]
            [AllowAnyStatusCode]
            Task<Models.H264PictureTimingTrimmingInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.H264PictureTimingTrimmingInputStream h264PictureTimingTrimmingInputStream);
            
            [Delete("/encoding/encodings/{encoding_id}/input-streams/trimming/h264-picture-timing/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/trimming/h264-picture-timing/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.H264PictureTimingTrimmingInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/trimming/h264-picture-timing")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.H264PictureTimingTrimmingInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
