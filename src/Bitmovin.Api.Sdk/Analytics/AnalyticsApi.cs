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

        public ExportsApi Exports { get; private set; }
        public ImpressionsApi Impressions { get; private set; }
        public InsightsApi Insights { get; private set; }
        public MetricsApi Metrics { get; private set; }
        public AdsApi Ads { get; private set; }
        public QueriesApi Queries { get; private set; }
        public LicensesApi Licenses { get; private set; }
        public OutputsApi Outputs { get; private set; }

    }
}
