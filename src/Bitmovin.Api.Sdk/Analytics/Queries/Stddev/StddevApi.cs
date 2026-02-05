using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Queries.Stddev
{
    /// <summary>
    /// API for StddevApi
    /// </summary>
    public class StddevApi
    {
        private readonly IStddevApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the StddevApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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
        /// <param name="analyticsStddevQueryRequest">Analytics Query Object</param>
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
