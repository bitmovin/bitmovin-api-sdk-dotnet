using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.CustomBuilds.Web;

namespace Bitmovin.Api.Sdk.Player.CustomBuilds
{
    /// <summary>
    /// API for CustomBuildsApi
    /// </summary>
    public class CustomBuildsApi
    {
        /// <summary>
        /// Initializes a new instance of the CustomBuildsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CustomBuildsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Web = new WebApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomBuildsApi
        /// </summary>
        public static BitmovinApiBuilder<CustomBuildsApi> Builder => new BitmovinApiBuilder<CustomBuildsApi>();

        /// <summary>
        /// Gets the Web API
        /// </summary>
        public WebApi Web { get; }
    }
}
