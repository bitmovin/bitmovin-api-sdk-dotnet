using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Alerting.Rules.Threshold
{
    public class ThresholdApi
    {
        private readonly IThresholdApiClient _apiClient;

        public ThresholdApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IThresholdApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ThresholdApi
        /// </summary>
        public static BitmovinApiBuilder<ThresholdApi> Builder => new BitmovinApiBuilder<ThresholdApi>();

        /// <summary>
        /// Create Analytics Alerting Rule
        /// </summary>
        /// <param name="licenseKey">License key (required)</param>
        /// <param name="analyticsAlertingRule">Analytics alerting rule details to be created</param>
        public async Task<Models.AnalyticsAlertingRule> CreateAsync(string licenseKey, Models.AnalyticsAlertingRule analyticsAlertingRule)
        {
            return await _apiClient.CreateAsync(licenseKey, analyticsAlertingRule);
        }

        /// <summary>
        /// Update Analytics Alerting Rule
        /// </summary>
        /// <param name="licenseKey">License key (required)</param>
        /// <param name="ruleId">Rule id (required)</param>
        /// <param name="analyticsAlertingRule">Analytics alerting rule details to be updated</param>
        public async Task<Models.AnalyticsAlertingRule> UpdateAsync(string licenseKey, string ruleId, Models.AnalyticsAlertingRule analyticsAlertingRule)
        {
            return await _apiClient.UpdateAsync(licenseKey, ruleId, analyticsAlertingRule);
        }

        internal interface IThresholdApiClient
        {
            [Post("/analytics/alerting/rules/{license_key}/threshold")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAlertingRule> CreateAsync([Path("license_key")] string licenseKey, [Body] Models.AnalyticsAlertingRule analyticsAlertingRule);

            [Put("/analytics/alerting/rules/{license_key}/threshold/{rule_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAlertingRule> UpdateAsync([Path("license_key")] string licenseKey, [Path("rule_id")] string ruleId, [Body] Models.AnalyticsAlertingRule analyticsAlertingRule);
        }
    }
}
