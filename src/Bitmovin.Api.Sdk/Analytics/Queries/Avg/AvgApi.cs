using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Queries.Avg
{
    /// <summary>
    /// API for AvgApi
    /// </summary>
    public class AvgApi
    {
        private readonly IAvgApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AvgApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AvgApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAvgApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of AvgApi
        /// </summary>
        public static BitmovinApiBuilder<AvgApi> Builder => new BitmovinApiBuilder<AvgApi>();

        /// <summary>
        /// Avg
        /// </summary>
        /// <param name="analyticsAvgQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AnalyticsAvgQueryRequest analyticsAvgQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsAvgQueryRequest);
        }

        internal interface IAvgApiClient
        {
            [Post("/analytics/queries/avg")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AnalyticsAvgQueryRequest analyticsAvgQueryRequest);
        }
    }
}
