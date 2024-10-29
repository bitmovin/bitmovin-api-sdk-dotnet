using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Impressions.Errors;

namespace Bitmovin.Api.Sdk.Analytics.Impressions
{
    public class ImpressionsApi
    {
        private readonly IImpressionsApiClient _apiClient;

        public ImpressionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IImpressionsApiClient>();
            Errors = new ErrorsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ImpressionsApi
        /// </summary>
        public static BitmovinApiBuilder<ImpressionsApi> Builder => new BitmovinApiBuilder<ImpressionsApi>();

        public ErrorsApi Errors { get; }

        /// <summary>
        /// List impressions
        /// </summary>
        /// <param name="analyticsImpressionsQuery">Analytics impressions query object</param>
        public async Task<Models.AnalyticsImpressionsResponse> GetImpressionsAsync(Models.AnalyticsImpressionsQuery analyticsImpressionsQuery)
        {
            return await _apiClient.GetImpressionsAsync(analyticsImpressionsQuery);
        }

        internal interface IImpressionsApiClient
        {
            [Post("/analytics/impressions")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsImpressionsResponse> GetImpressionsAsync([Body] Models.AnalyticsImpressionsQuery analyticsImpressionsQuery);
        }
    }
}
