using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Queries.Max
{
    public class MaxApi
    {
        private readonly IMaxApiClient _apiClient;

        public MaxApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMaxApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of MaxApi
        /// </summary>
        public static BitmovinApiBuilder<MaxApi> Builder => new BitmovinApiBuilder<MaxApi>();

        
        /// <summary>
        /// Max
        /// </summary>
        /// <param name="analyticsMaxQueryRequest">The request payload</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AnalyticsMaxQueryRequest analyticsMaxQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsMaxQueryRequest);
        }
        
        internal interface IMaxApiClient
        {
            
            [Post("/analytics/queries/max")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AnalyticsMaxQueryRequest analyticsMaxQueryRequest);
            
        }
        
    }
}
