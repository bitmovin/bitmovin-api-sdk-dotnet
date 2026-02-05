using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Count
{
    /// <summary>
    /// API for CountApi
    /// </summary>
    public class CountApi
    {
        private readonly ICountApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the CountApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CountApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICountApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CountApi
        /// </summary>
        public static BitmovinApiBuilder<CountApi> Builder => new BitmovinApiBuilder<CountApi>();

        /// <summary>
        /// Count
        /// </summary>
        /// <param name="adAnalyticsCountQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsCountQueryRequest adAnalyticsCountQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsCountQueryRequest);
        }

        internal interface ICountApiClient
        {
            [Post("/analytics/ads/queries/count")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsCountQueryRequest adAnalyticsCountQueryRequest);
        }
    }
}
