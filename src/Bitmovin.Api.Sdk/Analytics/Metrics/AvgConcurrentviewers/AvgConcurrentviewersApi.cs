using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Metrics.AvgConcurrentviewers
{
    /// <summary>
    /// API for AvgConcurrentviewersApi
    /// </summary>
    public class AvgConcurrentviewersApi
    {
        private readonly IAvgConcurrentviewersApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AvgConcurrentviewersApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AvgConcurrentviewersApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAvgConcurrentviewersApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of AvgConcurrentviewersApi
        /// </summary>
        public static BitmovinApiBuilder<AvgConcurrentviewersApi> Builder => new BitmovinApiBuilder<AvgConcurrentviewersApi>();

        /// <summary>
        /// Get metrics data
        /// </summary>
        /// <param name="analyticsMetricsQueryRequest">Analytics metrics query object</param>
        public async Task<Models.AnalyticsAvgConcurrentViewersResponse> CreateAsync(Models.AnalyticsMetricsQueryRequest analyticsMetricsQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsMetricsQueryRequest);
        }

        internal interface IAvgConcurrentviewersApiClient
        {
            [Post("/analytics/metrics/avg-concurrentviewers")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAvgConcurrentViewersResponse> CreateAsync([Body] Models.AnalyticsMetricsQueryRequest analyticsMetricsQueryRequest);
        }
    }
}
