using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Agents.Aisa;

namespace Bitmovin.Api.Sdk.Agents
{
    /// <summary>
    /// API for AgentsApi
    /// </summary>
    public class AgentsApi
    {
        /// <summary>
        /// Initializes a new instance of the AgentsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AgentsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Aisa = new AisaApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AgentsApi
        /// </summary>
        public static BitmovinApiBuilder<AgentsApi> Builder => new BitmovinApiBuilder<AgentsApi>();

        /// <summary>
        /// Gets the Aisa API
        /// </summary>
        public AisaApi Aisa { get; }
    }
}
