using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Impressions;
using Bitmovin.Api.Sdk.Analytics.Queries;
using Bitmovin.Api.Sdk.Analytics.Licenses;

namespace Bitmovin.Api.Sdk.Analytics
{
    public class AnalyticsApi
    {
        public AnalyticsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Impressions = new ImpressionsApi(apiClientFactory);
            Queries = new QueriesApi(apiClientFactory);
            Licenses = new LicensesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AnalyticsApi
        /// </summary>
        public static BitmovinApiBuilder<AnalyticsApi> Builder => new BitmovinApiBuilder<AnalyticsApi>();

        public ImpressionsApi Impressions { get; private set; }
        public QueriesApi Queries { get; private set; }
        public LicensesApi Licenses { get; private set; }

    }
}
