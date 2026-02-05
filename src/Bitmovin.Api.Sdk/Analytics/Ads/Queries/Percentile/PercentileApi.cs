using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Percentile
{
    /// <summary>
    /// API for PercentileApi
    /// </summary>
    public class PercentileApi
    {
        private readonly IPercentileApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the PercentileApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public PercentileApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPercentileApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of PercentileApi
        /// </summary>
        public static BitmovinApiBuilder<PercentileApi> Builder => new BitmovinApiBuilder<PercentileApi>();

        /// <summary>
        /// Percentile
        /// </summary>
        /// <param name="adAnalyticsPercentileQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsPercentileQueryRequest adAnalyticsPercentileQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsPercentileQueryRequest);
        }

        internal interface IPercentileApiClient
        {
            [Post("/analytics/ads/queries/percentile")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsPercentileQueryRequest adAnalyticsPercentileQueryRequest);
        }
    }
}
