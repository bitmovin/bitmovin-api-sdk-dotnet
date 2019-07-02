using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Subtitles.DvbTeletext
{
    public class DvbTeletextApi
    {
        private readonly IDvbTeletextApiClient _apiClient;

        public DvbTeletextApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDvbTeletextApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of DvbTeletextApi
        /// </summary>
        public static BitmovinApiBuilder<DvbTeletextApi> Builder => new BitmovinApiBuilder<DvbTeletextApi>();

        
        /// <summary>
        /// Add DVB-Teletext Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="dvbTeletextInputStream">The request payload</param>
        public async Task<Models.DvbTeletextInputStream> CreateAsync(string encodingId, Models.DvbTeletextInputStream dvbTeletextInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, dvbTeletextInputStream);
        }
        
        /// <summary>
        /// Delete DVB-Teletext Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the DVB-Teletext input stream.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// DVB-Teletext Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the DVB-Teletext input stream.</param>
        public async Task<Models.DvbTeletextInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// List DVB-Teletext Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DvbTeletextInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IDvbTeletextApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/input-streams/subtitles/dvb-teletext")]
            [AllowAnyStatusCode]
            Task<Models.DvbTeletextInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.DvbTeletextInputStream dvbTeletextInputStream);
            
            [Delete("/encoding/encodings/{encoding_id}/input-streams/subtitles/dvb-teletext/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/subtitles/dvb-teletext/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.DvbTeletextInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/subtitles/dvb-teletext")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DvbTeletextInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
