using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Exports;
using Bitmovin.Api.Sdk.Analytics.Impressions;
using Bitmovin.Api.Sdk.Analytics.Insights;
using Bitmovin.Api.Sdk.Analytics.Metrics;
using Bitmovin.Api.Sdk.Analytics.Ads;
using Bitmovin.Api.Sdk.Analytics.Queries;
using Bitmovin.Api.Sdk.Analytics.Licenses;
using Bitmovin.Api.Sdk.Analytics.Outputs;

namespace Bitmovin.Api.Sdk.Analytics
{
    public class AnalyticsApi
    {
        public AnalyticsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Exports = new ExportsApi(apiClientFactory);
            Impressions = new ImpressionsApi(apiClientFactory);
            Insights = new InsightsApi(apiClientFactory);
            Metrics = new MetricsApi(apiClientFactory);
            Ads = new AdsApi(apiClientFactory);
            Queries = new QueriesApi(apiClientFactory);
            Licenses = new LicensesApi(apiClientFactory);
            Outputs = new OutputsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AnalyticsApi
        /// </summary>
        public static BitmovinApiBuilder<AnalyticsApi> Builder => new BitmovinApiBuilder<AnalyticsApi>();

        public ExportsApi Exports { get; }
        public ImpressionsApi Impressions { get; }
        public InsightsApi Insights { get; }
        public MetricsApi Metrics { get; }
        public AdsApi Ads { get; }
        public QueriesApi Queries { get; }
        public LicensesApi Licenses { get; }
        public OutputsApi Outputs { get; }
    }
}
