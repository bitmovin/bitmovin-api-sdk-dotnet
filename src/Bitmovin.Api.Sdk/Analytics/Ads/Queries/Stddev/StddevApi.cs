using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Stddev
{
    public class StddevApi
    {
        private readonly IStddevApiClient _apiClient;

        public StddevApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStddevApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of StddevApi
        /// </summary>
        public static BitmovinApiBuilder<StddevApi> Builder => new BitmovinApiBuilder<StddevApi>();

        
        /// <summary>
        /// Stddev
        /// </summary>
        /// <param name="adAnalyticsStddevQueryRequest">The request payload</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsStddevQueryRequest adAnalyticsStddevQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsStddevQueryRequest);
        }
        
        internal interface IStddevApiClient
        {
            
            [Post("/analytics/ads/queries/stddev")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsStddevQueryRequest adAnalyticsStddevQueryRequest);
            
        }
        
    }
}
