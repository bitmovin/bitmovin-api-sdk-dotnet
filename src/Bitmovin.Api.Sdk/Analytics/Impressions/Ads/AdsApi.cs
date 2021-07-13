using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Impressions.Ads
{
    public class AdsApi
    {
        private readonly IAdsApiClient _apiClient;

        public AdsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAdsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of AdsApi
        /// </summary>
        public static BitmovinApiBuilder<AdsApi> Builder => new BitmovinApiBuilder<AdsApi>();

        /// <summary>
        /// Ads Impressions
        /// </summary>
        /// <param name="impressionId">Impression id (required)</param>
        /// <param name="analyticsLicenseKey">Analytics license</param>
        public async Task<Models.AnalyticsAdsImpressionsResponse> CreateAsync(string impressionId, Models.AnalyticsLicenseKey analyticsLicenseKey)
        {
            return await _apiClient.CreateAsync(impressionId, analyticsLicenseKey);
        }

        internal interface IAdsApiClient
        {
            [Post("/analytics/impressions/{impression_id}/ads")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAdsImpressionsResponse> CreateAsync([Path("impression_id")] string impressionId, [Body] Models.AnalyticsLicenseKey analyticsLicenseKey);
        }
    }
}
