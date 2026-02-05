using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries.Variance
{
    /// <summary>
    /// API for VarianceApi
    /// </summary>
    public class VarianceApi
    {
        private readonly IVarianceApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the VarianceApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public VarianceApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVarianceApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of VarianceApi
        /// </summary>
        public static BitmovinApiBuilder<VarianceApi> Builder => new BitmovinApiBuilder<VarianceApi>();

        /// <summary>
        /// Variance
        /// </summary>
        /// <param name="adAnalyticsVarianceQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AdAnalyticsVarianceQueryRequest adAnalyticsVarianceQueryRequest)
        {
            return await _apiClient.CreateAsync(adAnalyticsVarianceQueryRequest);
        }

        internal interface IVarianceApiClient
        {
            [Post("/analytics/ads/queries/variance")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AdAnalyticsVarianceQueryRequest adAnalyticsVarianceQueryRequest);
        }
    }
}
