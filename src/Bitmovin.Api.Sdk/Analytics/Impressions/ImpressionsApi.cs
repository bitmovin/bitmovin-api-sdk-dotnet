using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Impressions.Ads;
using Bitmovin.Api.Sdk.Analytics.Impressions.Errors;

namespace Bitmovin.Api.Sdk.Analytics.Impressions
{
    public class ImpressionsApi
    {
        private readonly IImpressionsApiClient _apiClient;

        public ImpressionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IImpressionsApiClient>();
            Ads = new AdsApi(apiClientFactory);
            Errors = new ErrorsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ImpressionsApi
        /// </summary>
        public static BitmovinApiBuilder<ImpressionsApi> Builder => new BitmovinApiBuilder<ImpressionsApi>();

        public AdsApi Ads { get; }
        public ErrorsApi Errors { get; }

        /// <summary>
        /// Impression Details
        /// </summary>
        /// <param name="impressionId">Impression id (required)</param>
        /// <param name="analyticsLicenseKey">Analytics license</param>
        public async Task<Models.AnalyticsImpressionDetails> CreateAsync(string impressionId, Models.AnalyticsLicenseKey analyticsLicenseKey)
        {
            return await _apiClient.CreateAsync(impressionId, analyticsLicenseKey);
        }

        /// <summary>
        /// List impressions
        /// </summary>
        /// <param name="analyticsImpressionsQuery">Analytics impressions query object</param>
        public async Task<Models.AnalyticsImpressionsResponse> GetImpressionsAsync(Models.AnalyticsImpressionsQuery analyticsImpressionsQuery)
        {
            return await _apiClient.GetImpressionsAsync(analyticsImpressionsQuery);
        }

        internal interface IImpressionsApiClient
        {
            [Post("/analytics/impressions/{impression_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsImpressionDetails> CreateAsync([Path("impression_id")] string impressionId, [Body] Models.AnalyticsLicenseKey analyticsLicenseKey);

            [Post("/analytics/impressions")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsImpressionsResponse> GetImpressionsAsync([Body] Models.AnalyticsImpressionsQuery analyticsImpressionsQuery);
        }
    }
}
