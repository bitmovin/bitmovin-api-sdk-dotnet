using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Insights.Organizations.Settings;

namespace Bitmovin.Api.Sdk.Analytics.Insights.Organizations
{
    public class OrganizationsApi
    {
        public OrganizationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Settings = new SettingsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OrganizationsApi
        /// </summary>
        public static BitmovinApiBuilder<OrganizationsApi> Builder => new BitmovinApiBuilder<OrganizationsApi>();

        public SettingsApi Settings { get; }
    }
}
