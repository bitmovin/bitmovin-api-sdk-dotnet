using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Metrics.AvgDroppedFrames
{
    public class AvgDroppedFramesApi
    {
        private readonly IAvgDroppedFramesApiClient _apiClient;

        public AvgDroppedFramesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAvgDroppedFramesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of AvgDroppedFramesApi
        /// </summary>
        public static BitmovinApiBuilder<AvgDroppedFramesApi> Builder => new BitmovinApiBuilder<AvgDroppedFramesApi>();

        /// <summary>
        /// Get metrics data
        /// </summary>
        /// <param name="analyticsMetricsQueryRequest">Analytics metrics query object</param>
        public async Task<Models.AnalyticsAvgDroppedFramesResponse> CreateAsync(Models.AnalyticsMetricsQueryRequest analyticsMetricsQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsMetricsQueryRequest);
        }

        internal interface IAvgDroppedFramesApiClient
        {
            [Post("/analytics/metrics/avg-dropped-frames")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAvgDroppedFramesResponse> CreateAsync([Body] Models.AnalyticsMetricsQueryRequest analyticsMetricsQueryRequest);
        }
    }
}
