using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Streams.Config.DomainRestriction;

namespace Bitmovin.Api.Sdk.Streams.Config
{
    public class ConfigApi
    {
        public ConfigApi(IBitmovinApiClientFactory apiClientFactory)
        {
            DomainRestriction = new DomainRestrictionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ConfigApi
        /// </summary>
        public static BitmovinApiBuilder<ConfigApi> Builder => new BitmovinApiBuilder<ConfigApi>();

        public DomainRestrictionApi DomainRestriction { get; }
    }
}
