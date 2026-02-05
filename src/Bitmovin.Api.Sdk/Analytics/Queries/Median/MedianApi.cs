using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Queries.Median
{
    /// <summary>
    /// API for MedianApi
    /// </summary>
    public class MedianApi
    {
        private readonly IMedianApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the MedianApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public MedianApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMedianApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of MedianApi
        /// </summary>
        public static BitmovinApiBuilder<MedianApi> Builder => new BitmovinApiBuilder<MedianApi>();

        /// <summary>
        /// Median
        /// </summary>
        /// <param name="analyticsMedianQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AnalyticsMedianQueryRequest analyticsMedianQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsMedianQueryRequest);
        }

        internal interface IMedianApiClient
        {
            [Post("/analytics/queries/median")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AnalyticsMedianQueryRequest analyticsMedianQueryRequest);
        }
    }
}
