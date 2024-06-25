using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Type;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ChunkedText;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.SegmentedRaw;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.PackedAudio;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Text;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Webm;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp3;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mxf;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.BroadcastTs;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWav;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveMov;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings
{
    public class MuxingsApi
    {
        private readonly IMuxingsApiClient _apiClient;

        public MuxingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMuxingsApiClient>();
            Type = new TypeApi(apiClientFactory);
            Fmp4 = new Fmp4Api(apiClientFactory);
            ChunkedText = new ChunkedTextApi(apiClientFactory);
            Cmaf = new CmafApi(apiClientFactory);
            SegmentedRaw = new SegmentedRawApi(apiClientFactory);
            PackedAudio = new PackedAudioApi(apiClientFactory);
            Text = new TextApi(apiClientFactory);
            Ts = new TsApi(apiClientFactory);
            Webm = new WebmApi(apiClientFactory);
            Mp3 = new Mp3Api(apiClientFactory);
            Mp4 = new Mp4Api(apiClientFactory);
            Mxf = new MxfApi(apiClientFactory);
            ProgressiveTs = new ProgressiveTsApi(apiClientFactory);
            BroadcastTs = new BroadcastTsApi(apiClientFactory);
            ProgressiveWav = new ProgressiveWavApi(apiClientFactory);
            ProgressiveWebm = new ProgressiveWebmApi(apiClientFactory);
            ProgressiveMov = new ProgressiveMovApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MuxingsApi
        /// </summary>
        public static BitmovinApiBuilder<MuxingsApi> Builder => new BitmovinApiBuilder<MuxingsApi>();

        public TypeApi Type { get; }
        public Fmp4Api Fmp4 { get; }
        public ChunkedTextApi ChunkedText { get; }
        public CmafApi Cmaf { get; }
        public SegmentedRawApi SegmentedRaw { get; }
        public PackedAudioApi PackedAudio { get; }
        public TextApi Text { get; }
        public TsApi Ts { get; }
        public WebmApi Webm { get; }
        public Mp3Api Mp3 { get; }
        public Mp4Api Mp4 { get; }
        public MxfApi Mxf { get; }
        public ProgressiveTsApi ProgressiveTs { get; }
        public BroadcastTsApi BroadcastTs { get; }
        public ProgressiveWavApi ProgressiveWav { get; }
        public ProgressiveWebmApi ProgressiveWebm { get; }
        public ProgressiveMovApi ProgressiveMov { get; }

        /// <summary>
        /// Muxing Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the muxing. (required)</param>
        public async Task<Models.Muxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List All Muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Muxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IMuxingsApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/muxings/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.Muxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Muxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

            /// <summary>
            /// Filter muxings to only show the ones with the stream modes specified. Accepts multiple values separated by commas.
            /// </summary>
            public ListQueryParams StreamMode(Models.StreamMode streamMode) => SetQueryParam("streamMode", streamMode);

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
