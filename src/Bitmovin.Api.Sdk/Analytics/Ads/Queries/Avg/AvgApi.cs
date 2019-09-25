using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Avg
{
    public class AvgApi
    {
        private readonly IAvgApiClient _apiClient;

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
        /// <param name="adAnalyticsAvgQueryRequest">The request payload</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsAvgQueryRequest adAnalyticsAvgQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsAvgQueryRequest);
        }
        
        internal interface IAvgApiClient
        {
            
            [Post("/analytics/ads/queries/avg")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsAvgQueryRequest adAnalyticsAvgQueryRequest);
            
        }
        
    }
}
