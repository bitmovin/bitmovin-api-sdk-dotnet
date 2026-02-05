using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Exports;
using Bitmovin.Api.Sdk.Analytics.Impressions;
using Bitmovin.Api.Sdk.Analytics.Insights;
using Bitmovin.Api.Sdk.Analytics.Metrics;
using Bitmovin.Api.Sdk.Analytics.Ads;
using Bitmovin.Api.Sdk.Analytics.Queries;
using Bitmovin.Api.Sdk.Analytics.Licenses;
using Bitmovin.Api.Sdk.Analytics.VirtualLicenses;
using Bitmovin.Api.Sdk.Analytics.Outputs;

namespace Bitmovin.Api.Sdk.Analytics
{
    /// <summary>
    /// API for AnalyticsApi
    /// </summary>
    public class AnalyticsApi
    {
        /// <summary>
        /// Initializes a new instance of the AnalyticsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AnalyticsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Exports = new ExportsApi(apiClientFactory);
            Impressions = new ImpressionsApi(apiClientFactory);
            Insights = new InsightsApi(apiClientFactory);
            Metrics = new MetricsApi(apiClientFactory);
            Ads = new AdsApi(apiClientFactory);
            Queries = new QueriesApi(apiClientFactory);
            Licenses = new LicensesApi(apiClientFactory);
            VirtualLicenses = new VirtualLicensesApi(apiClientFactory);
            Outputs = new OutputsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AnalyticsApi
        /// </summary>
        public static BitmovinApiBuilder<AnalyticsApi> Builder => new BitmovinApiBuilder<AnalyticsApi>();

        /// <summary>
        /// Gets the Exports API
        /// </summary>
        public ExportsApi Exports { get; }
        /// <summary>
        /// Gets the Impressions API
        /// </summary>
        public ImpressionsApi Impressions { get; }
        /// <summary>
        /// Gets the Insights API
        /// </summary>
        public InsightsApi Insights { get; }
        /// <summary>
        /// Gets the Metrics API
        /// </summary>
        public MetricsApi Metrics { get; }
        /// <summary>
        /// Gets the Ads API
        /// </summary>
        public AdsApi Ads { get; }
        /// <summary>
        /// Gets the Queries API
        /// </summary>
        public QueriesApi Queries { get; }
        /// <summary>
        /// Gets the Licenses API
        /// </summary>
        public LicensesApi Licenses { get; }
        /// <summary>
        /// Gets the VirtualLicenses API
        /// </summary>
        public VirtualLicensesApi VirtualLicenses { get; }
        /// <summary>
        /// Gets the Outputs API
        /// </summary>
        public OutputsApi Outputs { get; }
    }
}
