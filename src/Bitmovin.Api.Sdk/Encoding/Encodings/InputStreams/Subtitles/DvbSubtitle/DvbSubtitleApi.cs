using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Subtitles.DvbSubtitle
{
    public class DvbSubtitleApi
    {
        private readonly IDvbSubtitleApiClient _apiClient;

        public DvbSubtitleApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDvbSubtitleApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DvbSubtitleApi
        /// </summary>
        public static BitmovinApiBuilder<DvbSubtitleApi> Builder => new BitmovinApiBuilder<DvbSubtitleApi>();

        /// <summary>
        /// Add DVB Subtitle Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="dvbSubtitleInputStream">The DVB Subtitle Input Stream to be created</param>
        public async Task<Models.DvbSubtitleInputStream> CreateAsync(string encodingId, Models.DvbSubtitleInputStream dvbSubtitleInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, dvbSubtitleInputStream);
        }

        /// <summary>
        /// Delete DVB Subtitle Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the DVB Subtitle Input Stream. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// DVB Subtitle Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the DVB Subtitle Input Stream. (required)</param>
        public async Task<Models.DvbSubtitleInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List DVB Subtitle Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DvbSubtitleInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IDvbSubtitleApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/subtitles/dvb-subtitle")]
            [AllowAnyStatusCode]
            Task<Models.DvbSubtitleInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.DvbSubtitleInputStream dvbSubtitleInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/subtitles/dvb-subtitle/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/subtitles/dvb-subtitle/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.DvbSubtitleInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/subtitles/dvb-subtitle")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DvbSubtitleInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
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
