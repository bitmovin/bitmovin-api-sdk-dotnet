using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Impressions.Errors
{
    /// <summary>
    /// API for ErrorsApi
    /// </summary>
    public class ErrorsApi
    {
        private readonly IErrorsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ErrorsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ErrorsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IErrorsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ErrorsApi
        /// </summary>
        public static BitmovinApiBuilder<ErrorsApi> Builder => new BitmovinApiBuilder<ErrorsApi>();

        /// <summary>
        /// Impression Error Details
        /// </summary>
        /// <param name="impressionId">Impression id (required)</param>
        /// <param name="analyticsLicenseKey">Analytics license</param>
        public async Task<Models.AnalyticsErrorDetailsResponse> CreateAsync(string impressionId, Models.AnalyticsLicenseKey analyticsLicenseKey)
        {
            return await _apiClient.CreateAsync(impressionId, analyticsLicenseKey);
        }

        internal interface IErrorsApiClient
        {
            [Post("/analytics/impressions/{impression_id}/errors")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsErrorDetailsResponse> CreateAsync([Path("impression_id")] string impressionId, [Body] Models.AnalyticsLicenseKey analyticsLicenseKey);
        }
    }
}
