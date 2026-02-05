using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Streams.Config.DomainRestriction;

namespace Bitmovin.Api.Sdk.Streams.Config
{
    /// <summary>
    /// API for ConfigApi
    /// </summary>
    public class ConfigApi
    {
        /// <summary>
        /// Initializes a new instance of the ConfigApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ConfigApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DomainRestriction = new DomainRestrictionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ConfigApi
        /// </summary>
        public static BitmovinApiBuilder<ConfigApi> Builder => new BitmovinApiBuilder<ConfigApi>();

        /// <summary>
        /// Gets the DomainRestriction API
        /// </summary>
        public DomainRestrictionApi DomainRestriction { get; }
    }
}
