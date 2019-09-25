using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Queries.Stddev
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
        /// <param name="analyticsStddevQueryRequest">The request payload</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AnalyticsStddevQueryRequest analyticsStddevQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsStddevQueryRequest);
        }
        
        internal interface IStddevApiClient
        {
            
            [Post("/analytics/queries/stddev")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AnalyticsStddevQueryRequest analyticsStddevQueryRequest);
            
        }
        
    }
}
