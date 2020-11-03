using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Alerting.Rules.Threshold;

namespace Bitmovin.Api.Sdk.Analytics.Alerting.Rules
{
    public class RulesApi
    {
        private readonly IRulesApiClient _apiClient;

        public RulesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IRulesApiClient>();
            Threshold = new ThresholdApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of RulesApi
        /// </summary>
        public static BitmovinApiBuilder<RulesApi> Builder => new BitmovinApiBuilder<RulesApi>();

        public ThresholdApi Threshold { get; }

        /// <summary>
        /// Delete Analytics Alerting Rule By License Key And Id
        /// </summary>
        /// <param name="licenseKey">License key (required)</param>
        /// <param name="ruleId">Rule id (required)</param>
        public async Task<Models.AnalyticsAlertingRule> DeleteAsync(string licenseKey, string ruleId)
        {
            return await _apiClient.DeleteAsync(licenseKey, ruleId);
        }

        /// <summary>
        /// Get Analytics Alerting Rule By License Key And Id
        /// </summary>
        /// <param name="licenseKey">License key (required)</param>
        /// <param name="ruleId">Rule id (required)</param>
        public async Task<Models.AnalyticsAlertingRule> GetAsync(string licenseKey, string ruleId)
        {
            return await _apiClient.GetAsync(licenseKey, ruleId);
        }

        /// <summary>
        /// List Analytics Alerting Rules
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AnalyticsAlertingRule>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IRulesApiClient
        {
            [Delete("/analytics/alerting/rules/{license_key}/{rule_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAlertingRule> DeleteAsync([Path("license_key")] string licenseKey, [Path("rule_id")] string ruleId);

            [Get("/analytics/alerting/rules/{license_key}/{rule_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAlertingRule> GetAsync([Path("license_key")] string licenseKey, [Path("rule_id")] string ruleId);

            [Get("/analytics/alerting/rules")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AnalyticsAlertingRule>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}
