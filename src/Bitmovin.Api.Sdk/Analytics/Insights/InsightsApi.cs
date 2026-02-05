using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Insights.Organizations;

namespace Bitmovin.Api.Sdk.Analytics.Insights
{
    /// <summary>
    /// API for InsightsApi
    /// </summary>
    public class InsightsApi
    {
        /// <summary>
        /// Initializes a new instance of the InsightsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public InsightsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Organizations = new OrganizationsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InsightsApi
        /// </summary>
        public static BitmovinApiBuilder<InsightsApi> Builder => new BitmovinApiBuilder<InsightsApi>();

        /// <summary>
        /// Gets the Organizations API
        /// </summary>
        public OrganizationsApi Organizations { get; }
    }
}
