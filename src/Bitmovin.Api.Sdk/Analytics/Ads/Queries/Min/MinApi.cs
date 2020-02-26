using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Min
{
    public class MinApi
    {
        private readonly IMinApiClient _apiClient;

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
