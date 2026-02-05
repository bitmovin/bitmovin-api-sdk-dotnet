using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Max
{
    /// <summary>
    /// API for MaxApi
    /// </summary>
    public class MaxApi
    {
        private readonly IMaxApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the MaxApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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
        /// <param name="adAnalyticsMaxQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsMaxQueryRequest adAnalyticsMaxQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsMaxQueryRequest);
        }

        internal interface IMaxApiClient
        {
            [Post("/analytics/ads/queries/max")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsMaxQueryRequest adAnalyticsMaxQueryRequest);
        }
    }
}
