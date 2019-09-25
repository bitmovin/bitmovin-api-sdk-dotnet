using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Median
{
    public class MedianApi
    {
        private readonly IMedianApiClient _apiClient;

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
        /// <param name="adAnalyticsMedianQueryRequest">The request payload</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsMedianQueryRequest adAnalyticsMedianQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsMedianQueryRequest);
        }
        
        internal interface IMedianApiClient
        {
            
            [Post("/analytics/ads/queries/median")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsMedianQueryRequest adAnalyticsMedianQueryRequest);
            
        }
        
    }
}
