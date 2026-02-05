using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Metrics.MaxConcurrentviewers
{
    /// <summary>
    /// API for MaxConcurrentviewersApi
    /// </summary>
    public class MaxConcurrentviewersApi
    {
        private readonly IMaxConcurrentviewersApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the MaxConcurrentviewersApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public MaxConcurrentviewersApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMaxConcurrentviewersApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of MaxConcurrentviewersApi
        /// </summary>
        public static BitmovinApiBuilder<MaxConcurrentviewersApi> Builder => new BitmovinApiBuilder<MaxConcurrentviewersApi>();

        /// <summary>
        /// Get metrics data
        /// </summary>
        /// <param name="analyticsMetricsQueryRequest">Analytics metrics query object</param>
        public async Task<Models.AnalyticsMaxConcurrentViewersResponse> CreateAsync(Models.AnalyticsMetricsQueryRequest analyticsMetricsQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsMetricsQueryRequest);
        }

        internal interface IMaxConcurrentviewersApiClient
        {
            [Post("/analytics/metrics/max-concurrentviewers")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsMaxConcurrentViewersResponse> CreateAsync([Body] Models.AnalyticsMetricsQueryRequest analyticsMetricsQueryRequest);
        }
    }
}
