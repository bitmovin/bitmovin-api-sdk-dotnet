using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Queries.Count;
using Bitmovin.Api.Sdk.Analytics.Queries.Sum;
using Bitmovin.Api.Sdk.Analytics.Queries.Avg;
using Bitmovin.Api.Sdk.Analytics.Queries.Min;
using Bitmovin.Api.Sdk.Analytics.Queries.Max;
using Bitmovin.Api.Sdk.Analytics.Queries.Stddev;
using Bitmovin.Api.Sdk.Analytics.Queries.Percentile;
using Bitmovin.Api.Sdk.Analytics.Queries.Variance;
using Bitmovin.Api.Sdk.Analytics.Queries.Median;

namespace Bitmovin.Api.Sdk.Analytics.Queries
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

        public CountApi Count { get; private set; }
        public SumApi Sum { get; private set; }
        public AvgApi Avg { get; private set; }
        public MinApi Min { get; private set; }
        public MaxApi Max { get; private set; }
        public StddevApi Stddev { get; private set; }
        public PercentileApi Percentile { get; private set; }
        public VarianceApi Variance { get; private set; }
        public MedianApi Median { get; private set; }

    }
}
