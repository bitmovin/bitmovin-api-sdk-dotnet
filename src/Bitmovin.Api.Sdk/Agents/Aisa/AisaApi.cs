using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Agents.Aisa.Sessions;

namespace Bitmovin.Api.Sdk.Agents.Aisa
{
    /// <summary>
    /// API for AisaApi
    /// </summary>
    public class AisaApi
    {
        /// <summary>
        /// Initializes a new instance of the AisaApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AisaApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Sessions = new SessionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AisaApi
        /// </summary>
        public static BitmovinApiBuilder<AisaApi> Builder => new BitmovinApiBuilder<AisaApi>();

        /// <summary>
        /// Gets the Sessions API
        /// </summary>
        public SessionsApi Sessions { get; }
    }
}
