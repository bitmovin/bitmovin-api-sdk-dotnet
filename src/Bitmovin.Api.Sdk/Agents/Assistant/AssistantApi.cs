using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Agents.Assistant.Sessions;

namespace Bitmovin.Api.Sdk.Agents.Assistant
{
    /// <summary>
    /// API for AssistantApi
    /// </summary>
    public class AssistantApi
    {
        /// <summary>
        /// Initializes a new instance of the AssistantApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AssistantApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Sessions = new SessionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AssistantApi
        /// </summary>
        public static BitmovinApiBuilder<AssistantApi> Builder => new BitmovinApiBuilder<AssistantApi>();

        /// <summary>
        /// Gets the Sessions API
        /// </summary>
        public SessionsApi Sessions { get; }
    }
}
