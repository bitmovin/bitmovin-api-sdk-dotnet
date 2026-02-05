using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Min
{
    /// <summary>
    /// API for MinApi
    /// </summary>
    public class MinApi
    {
        private readonly IMinApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the MinApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public MinApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMinApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of MinApi
        /// </summary>
        public static BitmovinApiBuilder<MinApi> Builder => new BitmovinApiBuilder<MinApi>();

        /// <summary>
        /// Min
        /// </summary>
        /// <param name="adAnalyticsMinQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsMinQueryRequest adAnalyticsMinQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsMinQueryRequest);
        }

        internal interface IMinApiClient
        {
            [Post("/analytics/ads/queries/min")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsMinQueryRequest adAnalyticsMinQueryRequest);
        }
    }
}
