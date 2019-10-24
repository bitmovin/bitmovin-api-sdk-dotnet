using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Type;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.AudioMix;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Ingest;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Sidecar;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Concatenation;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.File;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Subtitles;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams
{
    public class InputStreamsApi
    {
        private readonly IInputStreamsApiClient _apiClient;

        public InputStreamsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInputStreamsApiClient>();

            Type = new TypeApi(apiClientFactory);
            AudioMix = new AudioMixApi(apiClientFactory);
            Ingest = new IngestApi(apiClientFactory);
            Sidecar = new SidecarApi(apiClientFactory);
            Concatenation = new ConcatenationApi(apiClientFactory);
            File = new FileApi(apiClientFactory);
            Trimming = new TrimmingApi(apiClientFactory);
            Subtitles = new SubtitlesApi(apiClientFactory);
            Captions = new CaptionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InputStreamsApi
        /// </summary>
        public static BitmovinApiBuilder<InputStreamsApi> Builder => new BitmovinApiBuilder<InputStreamsApi>();

        public TypeApi Type { get; private set; }
        public AudioMixApi AudioMix { get; private set; }
        public IngestApi Ingest { get; private set; }
        public SidecarApi Sidecar { get; private set; }
        public ConcatenationApi Concatenation { get; private set; }
        public FileApi File { get; private set; }
        public TrimmingApi Trimming { get; private set; }
        public SubtitlesApi Subtitles { get; private set; }
        public CaptionsApi Captions { get; private set; }
        
        /// <summary>
        /// Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="inputStreamId">Id of the input stream.</param>
        public async Task<Models.InputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }
        
        /// <summary>
        /// List All Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.InputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IInputStreamsApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.InputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
            [Get("/encoding/encodings/{encoding_id}/input-streams")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.InputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
