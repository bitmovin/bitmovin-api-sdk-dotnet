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
    /// <summary>
    /// API for QueriesApi
    /// </summary>
    public class QueriesApi
    {
        /// <summary>
        /// Initializes a new instance of the QueriesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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

        /// <summary>
        /// Gets the Count API
        /// </summary>
        public CountApi Count { get; }
        /// <summary>
        /// Gets the Sum API
        /// </summary>
        public SumApi Sum { get; }
        /// <summary>
        /// Gets the Avg API
        /// </summary>
        public AvgApi Avg { get; }
        /// <summary>
        /// Gets the Min API
        /// </summary>
        public MinApi Min { get; }
        /// <summary>
        /// Gets the Max API
        /// </summary>
        public MaxApi Max { get; }
        /// <summary>
        /// Gets the Stddev API
        /// </summary>
        public StddevApi Stddev { get; }
        /// <summary>
        /// Gets the Percentile API
        /// </summary>
        public PercentileApi Percentile { get; }
        /// <summary>
        /// Gets the Variance API
        /// </summary>
        public VarianceApi Variance { get; }
        /// <summary>
        /// Gets the Median API
        /// </summary>
        public MedianApi Median { get; }
    }
}
