using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Insights.Organizations;

namespace Bitmovin.Api.Sdk.Analytics.Insights
{
    public class InsightsApi
    {
        public InsightsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Organizations = new OrganizationsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InsightsApi
        /// </summary>
        public static BitmovinApiBuilder<InsightsApi> Builder => new BitmovinApiBuilder<InsightsApi>();

        public OrganizationsApi Organizations { get; private set; }

    }
}
