using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Streams.Video;
using Bitmovin.Api.Sdk.Streams.Live;
using Bitmovin.Api.Sdk.Streams.Config;
using Bitmovin.Api.Sdk.Streams.Search;
using Bitmovin.Api.Sdk.Streams.SigningKeys;

namespace Bitmovin.Api.Sdk.Streams
{
    /// <summary>
    /// API for StreamsApi
    /// </summary>
    public class StreamsApi
    {
        /// <summary>
        /// Initializes a new instance of the StreamsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public StreamsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Video = new VideoApi(apiClientFactory);
            Live = new LiveApi(apiClientFactory);
            Config = new ConfigApi(apiClientFactory);
            Search = new SearchApi(apiClientFactory);
            SigningKeys = new SigningKeysApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of StreamsApi
        /// </summary>
        public static BitmovinApiBuilder<StreamsApi> Builder => new BitmovinApiBuilder<StreamsApi>();

        /// <summary>
        /// Gets the Video API
        /// </summary>
        public VideoApi Video { get; }
        /// <summary>
        /// Gets the Live API
        /// </summary>
        public LiveApi Live { get; }
        /// <summary>
        /// Gets the Config API
        /// </summary>
        public ConfigApi Config { get; }
        /// <summary>
        /// Gets the Search API
        /// </summary>
        public SearchApi Search { get; }
        /// <summary>
        /// Gets the SigningKeys API
        /// </summary>
        public SigningKeysApi SigningKeys { get; }
    }
}
