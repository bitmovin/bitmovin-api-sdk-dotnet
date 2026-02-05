using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Insights.Organizations.Settings
{
    /// <summary>
    /// API for SettingsApi
    /// </summary>
    public class SettingsApi
    {
        private readonly ISettingsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SettingsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SettingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISettingsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of SettingsApi
        /// </summary>
        public static BitmovinApiBuilder<SettingsApi> Builder => new BitmovinApiBuilder<SettingsApi>();

        /// <summary>
        /// Get the current organization settings for industry insights
        /// </summary>
        /// <param name="organizationId">Organization id (required)</param>
        public async Task<Models.AnalyticsInsightsOrganizationSettings> GetAsync(string organizationId)
        {
            return await _apiClient.GetAsync(organizationId);
        }

        /// <summary>
        /// Update the organization settings for industry insights
        /// </summary>
        /// <param name="organizationId">Organization id (required)</param>
        /// <param name="analyticsInsightsOrganizationSettingsRequest">Organization settings to be updated</param>
        public async Task<Models.AnalyticsInsightsOrganizationSettings> UpdateAsync(string organizationId, Models.AnalyticsInsightsOrganizationSettingsRequest analyticsInsightsOrganizationSettingsRequest)
        {
            return await _apiClient.UpdateAsync(organizationId, analyticsInsightsOrganizationSettingsRequest);
        }

        internal interface ISettingsApiClient
        {
            [Get("/analytics/insights/organizations/{organization_id}/settings")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsInsightsOrganizationSettings> GetAsync([Path("organization_id")] string organizationId);

            [Put("/analytics/insights/organizations/{organization_id}/settings")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsInsightsOrganizationSettings> UpdateAsync([Path("organization_id")] string organizationId, [Body] Models.AnalyticsInsightsOrganizationSettingsRequest analyticsInsightsOrganizationSettingsRequest);
        }
    }
}
