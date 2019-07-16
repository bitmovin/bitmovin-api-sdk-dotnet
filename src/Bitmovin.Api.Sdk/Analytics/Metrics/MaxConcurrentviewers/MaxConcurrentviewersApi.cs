using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Metrics.MaxConcurrentviewers
{
    public class MaxConcurrentviewersApi
    {
        private readonly IMaxConcurrentviewersApiClient _apiClient;

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
        /// <param name="analyticsMetricsQueryRequest">The request payload</param>
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
