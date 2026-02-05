using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.Licenses.Analytics
{
    /// <summary>
    /// API for AnalyticsApi
    /// </summary>
    public class AnalyticsApi
    {
        private readonly IAnalyticsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AnalyticsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AnalyticsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAnalyticsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of AnalyticsApi
        /// </summary>
        public static BitmovinApiBuilder<AnalyticsApi> Builder => new BitmovinApiBuilder<AnalyticsApi>();

        /// <summary>
        /// Activate Analytics
        /// </summary>
        /// <param name="licenseId">Id of the Player License (required)</param>
        /// <param name="playerLicenseAnalytics">The Analytics key to be added to the Player License</param>
        public async Task<Models.PlayerLicenseAnalytics> CreateAsync(string licenseId, Models.PlayerLicenseAnalytics playerLicenseAnalytics)
        {
            return await _apiClient.CreateAsync(licenseId, playerLicenseAnalytics);
        }

        /// <summary>
        /// Deactivate Analytics
        /// </summary>
        /// <param name="licenseId">Id of license (required)</param>
        public async Task<Models.PlayerLicenseAnalytics> DeleteAsync(string licenseId)
        {
            return await _apiClient.DeleteAsync(licenseId);
        }

        internal interface IAnalyticsApiClient
        {
            [Post("/player/licenses/{license_id}/analytics")]
            [AllowAnyStatusCode]
            Task<Models.PlayerLicenseAnalytics> CreateAsync([Path("license_id")] string licenseId, [Body] Models.PlayerLicenseAnalytics playerLicenseAnalytics);

            [Delete("/player/licenses/{license_id}/analytics")]
            [AllowAnyStatusCode]
            Task<Models.PlayerLicenseAnalytics> DeleteAsync([Path("license_id")] string licenseId);
        }
    }
}
