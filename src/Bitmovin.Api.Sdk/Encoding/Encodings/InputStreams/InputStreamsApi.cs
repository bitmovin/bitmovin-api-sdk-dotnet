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
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.DolbyAtmos;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.DolbyVision;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams
{
    /// <summary>
    /// API for InputStreamsApi
    /// </summary>
    public class InputStreamsApi
    {
        private readonly IInputStreamsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the InputStreamsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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
            DolbyAtmos = new DolbyAtmosApi(apiClientFactory);
            DolbyVision = new DolbyVisionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InputStreamsApi
        /// </summary>
        public static BitmovinApiBuilder<InputStreamsApi> Builder => new BitmovinApiBuilder<InputStreamsApi>();

        /// <summary>
        /// Gets the Type API
        /// </summary>
        public TypeApi Type { get; }
        /// <summary>
        /// Gets the AudioMix API
        /// </summary>
        public AudioMixApi AudioMix { get; }
        /// <summary>
        /// Gets the Ingest API
        /// </summary>
        public IngestApi Ingest { get; }
        /// <summary>
        /// Gets the Sidecar API
        /// </summary>
        public SidecarApi Sidecar { get; }
        /// <summary>
        /// Gets the Concatenation API
        /// </summary>
        public ConcatenationApi Concatenation { get; }
        /// <summary>
        /// Gets the File API
        /// </summary>
        public FileApi File { get; }
        /// <summary>
        /// Gets the Trimming API
        /// </summary>
        public TrimmingApi Trimming { get; }
        /// <summary>
        /// Gets the Subtitles API
        /// </summary>
        public SubtitlesApi Subtitles { get; }
        /// <summary>
        /// Gets the Captions API
        /// </summary>
        public CaptionsApi Captions { get; }
        /// <summary>
        /// Gets the DolbyAtmos API
        /// </summary>
        public DolbyAtmosApi DolbyAtmos { get; }
        /// <summary>
        /// Gets the DolbyVision API
        /// </summary>
        public DolbyVisionApi DolbyVision { get; }

        /// <summary>
        /// Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the input stream. (required)</param>
        public async Task<Models.InputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List All Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
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
            Task<Models.PaginationResponse<Models.InputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
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
