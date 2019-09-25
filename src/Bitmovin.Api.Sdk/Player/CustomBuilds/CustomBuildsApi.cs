using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.CustomBuilds.Web;

namespace Bitmovin.Api.Sdk.Player.CustomBuilds
{
    public class CustomBuildsApi
    {
        public CustomBuildsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Web = new WebApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomBuildsApi
        /// </summary>
        public static BitmovinApiBuilder<CustomBuildsApi> Builder => new BitmovinApiBuilder<CustomBuildsApi>();

        public WebApi Web { get; private set; }

    }
}
