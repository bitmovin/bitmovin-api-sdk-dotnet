using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Count;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Sum;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Avg;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Min;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Max;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Stddev;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Percentile;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Variance;
using Bitmovin.Api.Sdk.Analytics.Ads.Queries.Median;

namespace Bitmovin.Api.Sdk.Analytics.Ads.Queries
{
    public class QueriesApi
    {
        public QueriesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Count = new CountApi(apiClientFactory);
            Sum = new SumApi(apiClientFactory);
            Avg = new AvgApi(apiClientFactory);
            Min = new MinApi(apiClientFactory);
            Max = new MaxApi(apiClientFactory);
            Stddev = new StddevApi(apiClientFactory);
            Percentile = new PercentileApi(apiClientFactory);
            Variance = new VarianceApi(apiClientFactory);
            Median = new MedianApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of QueriesApi
        /// </summary>
        public static BitmovinApiBuilder<QueriesApi> Builder => new BitmovinApiBuilder<QueriesApi>();

        public CountApi Count { get; }
        public SumApi Sum { get; }
        public AvgApi Avg { get; }
        public MinApi Min { get; }
        public MaxApi Max { get; }
        public StddevApi Stddev { get; }
        public PercentileApi Percentile { get; }
        public VarianceApi Variance { get; }
        public MedianApi Median { get; }
    }
}
