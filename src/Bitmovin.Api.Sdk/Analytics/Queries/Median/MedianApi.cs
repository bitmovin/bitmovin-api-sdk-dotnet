using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Queries.Median
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
        /// <param name="analyticsMedianQueryRequest">The request payload</param>
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
