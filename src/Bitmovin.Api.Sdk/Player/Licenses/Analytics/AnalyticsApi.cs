using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.Licenses.Analytics
{
    public class AnalyticsApi
    {
        private readonly IAnalyticsApiClient _apiClient;

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
        /// <param name="licenseId">Id of the Player License</param>
        /// <param name="playerLicenseAnalytics">The request payload</param>
        public async Task<Models.PlayerLicenseAnalytics> CreateAsync(string licenseId, Models.PlayerLicenseAnalytics playerLicenseAnalytics)
        {
            return await _apiClient.CreateAsync(licenseId, playerLicenseAnalytics);
        }
        
        /// <summary>
        /// Deactivate Analytics
        /// </summary>
        /// <param name="licenseId">Id of license</param>
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
