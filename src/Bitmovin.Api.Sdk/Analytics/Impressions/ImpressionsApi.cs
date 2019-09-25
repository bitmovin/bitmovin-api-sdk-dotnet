using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Impressions
{
    public class ImpressionsApi
    {
        private readonly IImpressionsApiClient _apiClient;

        public ImpressionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IImpressionsApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of ImpressionsApi
        /// </summary>
        public static BitmovinApiBuilder<ImpressionsApi> Builder => new BitmovinApiBuilder<ImpressionsApi>();

        
        /// <summary>
        /// Impression Details
        /// </summary>
        /// <param name="impressionId">Impression id</param>
        /// <param name="analyticsLicenseKey">The request payload</param>
        public async Task<Models.AnalyticsImpressionDetails> CreateAsync(string impressionId, Models.AnalyticsLicenseKey analyticsLicenseKey)
        {
            return await _apiClient.CreateAsync(impressionId, analyticsLicenseKey);
        }
        
        internal interface IImpressionsApiClient
        {
            
            [Post("/analytics/impressions/{impression_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsImpressionDetails> CreateAsync([Path("impression_id")] string impressionId, [Body] Models.AnalyticsLicenseKey analyticsLicenseKey);
            
        }
        
    }
}
