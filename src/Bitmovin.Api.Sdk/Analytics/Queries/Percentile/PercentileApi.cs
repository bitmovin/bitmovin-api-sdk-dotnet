using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Queries.Percentile
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
        /// <param name="analyticsPercentileQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AnalyticsPercentileQueryRequest analyticsPercentileQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsPercentileQueryRequest);
        }

        internal interface IPercentileApiClient
        {
            [Post("/analytics/queries/percentile")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AnalyticsPercentileQueryRequest analyticsPercentileQueryRequest);
        }
    }
}
