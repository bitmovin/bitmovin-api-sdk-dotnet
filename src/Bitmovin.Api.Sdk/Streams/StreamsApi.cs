using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Streams.Search;
using Bitmovin.Api.Sdk.Streams.Video;
using Bitmovin.Api.Sdk.Streams.Live;
using Bitmovin.Api.Sdk.Streams.SigningKeys;

namespace Bitmovin.Api.Sdk.Streams
{
    public class StreamsApi
    {
        public StreamsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Search = new SearchApi(apiClientFactory);
            Video = new VideoApi(apiClientFactory);
            Live = new LiveApi(apiClientFactory);
            SigningKeys = new SigningKeysApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of StreamsApi
        /// </summary>
        public static BitmovinApiBuilder<StreamsApi> Builder => new BitmovinApiBuilder<StreamsApi>();

        public SearchApi Search { get; }
        public VideoApi Video { get; }
        public LiveApi Live { get; }
        public SigningKeysApi SigningKeys { get; }
    }
}
