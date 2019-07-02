using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Input;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Inputs;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Filters;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Bifs;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Thumbnails;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Sprites;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Qc;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams
{
    public class StreamsApi
    {
        private readonly IStreamsApiClient _apiClient;

        public StreamsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStreamsApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
            Input = new InputApi(apiClientFactory);
            Inputs = new InputsApi(apiClientFactory);
            Filters = new FiltersApi(apiClientFactory);
            BurnInSubtitles = new BurnInSubtitlesApi(apiClientFactory);
            Captions = new CaptionsApi(apiClientFactory);
            Bifs = new BifsApi(apiClientFactory);
            Thumbnails = new ThumbnailsApi(apiClientFactory);
            Sprites = new SpritesApi(apiClientFactory);
            Qc = new QcApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of StreamsApi
        /// </summary>
        public static BitmovinApiBuilder<StreamsApi> Builder => new BitmovinApiBuilder<StreamsApi>();

        public CustomdataApi Customdata { get; private set; }
        public InputApi Input { get; private set; }
        public InputsApi Inputs { get; private set; }
        public FiltersApi Filters { get; private set; }
        public BurnInSubtitlesApi BurnInSubtitles { get; private set; }
        public CaptionsApi Captions { get; private set; }
        public BifsApi Bifs { get; private set; }
        public ThumbnailsApi Thumbnails { get; private set; }
        public SpritesApi Sprites { get; private set; }
        public QcApi Qc { get; private set; }
        
        /// <summary>
        /// Add Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="stream">The request payload</param>
        public async Task<Models.Stream> CreateAsync(string encodingId, Models.Stream stream)
        {
            return await _apiClient.CreateAsync(encodingId, stream);
        }
        
        /// <summary>
        /// Delete Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId);
        }
        
        /// <summary>
        /// Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        public async Task<Models.Stream> GetAsync(string encodingId, string streamId)
        {
            return await _apiClient.GetAsync(encodingId, streamId);
        }
        
        /// <summary>
        /// List Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Stream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IStreamsApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/streams")]
            [AllowAnyStatusCode]
            Task<Models.Stream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Stream stream);
            
            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId);
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.Stream> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId);
            
            [Get("/encoding/encodings/{encoding_id}/streams")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Stream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
