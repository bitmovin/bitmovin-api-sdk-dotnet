using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Subtitles.Dvbsub.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Subtitles.Dvbsub
{
    public class DvbsubApi
    {
        private readonly IDvbsubApiClient _apiClient;

        public DvbsubApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDvbsubApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DvbsubApi
        /// </summary>
        public static BitmovinApiBuilder<DvbsubApi> Builder => new BitmovinApiBuilder<DvbsubApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Burn-In DVB-SUB Subtitle into Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="streamDvbSubSubtitle">The request payload</param>
        public async Task<Models.StreamDvbSubSubtitle> CreateAsync(string encodingId, string streamId, Models.StreamDvbSubSubtitle streamDvbSubSubtitle)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, streamDvbSubSubtitle);
        }
        
        /// <summary>
        /// Delete Specific DVB-SUB Subtitle from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="subtitleId">Id of the subtitle.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, subtitleId);
        }
        
        /// <summary>
        /// Subtitle DVB-SUB BurnIn Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="subtitleId">Id of the subtitle.</param>
        public async Task<Models.StreamDvbSubSubtitle> GetAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, subtitleId);
        }
        
        /// <summary>
        /// List the DVB-SUB subtitles of a stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StreamDvbSubSubtitle>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/subtitles/dvbsub")]
            [AllowAnyStatusCode]
            Task<Models.StreamDvbSubSubtitle> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.StreamDvbSubSubtitle streamDvbSubSubtitle);
            
            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/subtitles/dvbsub/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/subtitles/dvbsub/{subtitle_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamDvbSubSubtitle> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/subtitles/dvbsub")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StreamDvbSubSubtitle>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
