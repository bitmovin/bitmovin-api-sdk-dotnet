using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Sum
{
    public class SumApi
    {
        private readonly ISumApiClient _apiClient;

        public SumApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISumApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of SumApi
        /// </summary>
        public static BitmovinApiBuilder<SumApi> Builder => new BitmovinApiBuilder<SumApi>();

        
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="adAnalyticsSumQueryRequest">The request payload</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsSumQueryRequest adAnalyticsSumQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsSumQueryRequest);
        }
        
        internal interface ISumApiClient
        {
            
            [Post("/analytics/ads/queries/sum")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsSumQueryRequest adAnalyticsSumQueryRequest);
            
        }
        
    }
}
