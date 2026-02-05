using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.Channels;
using Bitmovin.Api.Sdk.Player.Licenses;
using Bitmovin.Api.Sdk.Player.CustomBuilds;

namespace Bitmovin.Api.Sdk.Player
{
    /// <summary>
    /// API for PlayerApi
    /// </summary>
    public class PlayerApi
    {
        /// <summary>
        /// Initializes a new instance of the PlayerApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public PlayerApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Channels = new ChannelsApi(apiClientFactory);
            Licenses = new LicensesApi(apiClientFactory);
            CustomBuilds = new CustomBuildsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of PlayerApi
        /// </summary>
        public static BitmovinApiBuilder<PlayerApi> Builder => new BitmovinApiBuilder<PlayerApi>();

        /// <summary>
        /// Gets the Channels API
        /// </summary>
        public ChannelsApi Channels { get; }
        /// <summary>
        /// Gets the Licenses API
        /// </summary>
        public LicensesApi Licenses { get; }
        /// <summary>
        /// Gets the CustomBuilds API
        /// </summary>
        public CustomBuildsApi CustomBuilds { get; }
    }
}
