using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.Channels;
using Bitmovin.Api.Sdk.Player.Licenses;
using Bitmovin.Api.Sdk.Player.CustomBuilds;

namespace Bitmovin.Api.Sdk.Player
{
    public class PlayerApi
    {
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

        public ChannelsApi Channels { get; }
        public LicensesApi Licenses { get; }
        public CustomBuildsApi CustomBuilds { get; }
    }
}
