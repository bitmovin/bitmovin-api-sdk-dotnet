using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Insights.Organizations.Settings;

namespace Bitmovin.Api.Sdk.Analytics.Insights.Organizations
{
    /// <summary>
    /// API for OrganizationsApi
    /// </summary>
    public class OrganizationsApi
    {
        /// <summary>
        /// Initializes a new instance of the OrganizationsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public OrganizationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Settings = new SettingsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OrganizationsApi
        /// </summary>
        public static BitmovinApiBuilder<OrganizationsApi> Builder => new BitmovinApiBuilder<OrganizationsApi>();

        /// <summary>
        /// Gets the Settings API
        /// </summary>
        public SettingsApi Settings { get; }
    }
}
