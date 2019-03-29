using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Licenses.Domains;

namespace Bitmovin.Api.Sdk.Analytics.Licenses
{
    public class LicensesApi
    {
        private readonly ILicensesApiClient _apiClient;

        public LicensesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILicensesApiClient>();

            Domains = new DomainsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LicensesApi
        /// </summary>
        public static BitmovinApiBuilder<LicensesApi> Builder => new BitmovinApiBuilder<LicensesApi>();

        public DomainsApi Domains { get; private set; }
        
        /// <summary>
        /// Get License
        /// </summary>
        /// <param name="licenseId">License id</param>
        public async Task<Models.AnalyticsLicense> GetAsync(string licenseId)
        {
            return await _apiClient.GetAsync(licenseId);
        }
        
        /// <summary>
        /// List Analytics Licenses
        /// </summary>
        public async Task<Models.PaginationResponse<Models.AnalyticsLicense>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }
        
        internal interface ILicensesApiClient
        {
            
            [Get("/analytics/licenses/{license_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsLicense> GetAsync([Path("license_id")] string licenseId);
            
            [Get("/analytics/licenses")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AnalyticsLicense>> ListAsync();
            
        }
        
    }
}
