using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Streams.Configs;
using Bitmovin.Api.Sdk.Streams.Video;
using Bitmovin.Api.Sdk.Streams.Live;

namespace Bitmovin.Api.Sdk.Streams
{
    public class StreamsApi
    {
        public StreamsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Configs = new ConfigsApi(apiClientFactory);
            Video = new VideoApi(apiClientFactory);
            Live = new LiveApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of StreamsApi
        /// </summary>
        public static BitmovinApiBuilder<StreamsApi> Builder => new BitmovinApiBuilder<StreamsApi>();

        public ConfigsApi Configs { get; }
        public VideoApi Video { get; }
        public LiveApi Live { get; }
    }
}
