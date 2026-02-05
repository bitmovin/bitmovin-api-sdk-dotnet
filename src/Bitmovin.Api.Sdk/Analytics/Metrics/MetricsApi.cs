using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Metrics.MaxConcurrentviewers;
using Bitmovin.Api.Sdk.Analytics.Metrics.AvgConcurrentviewers;
using Bitmovin.Api.Sdk.Analytics.Metrics.AvgDroppedFrames;

namespace Bitmovin.Api.Sdk.Analytics.Metrics
{
    /// <summary>
    /// API for MetricsApi
    /// </summary>
    public class MetricsApi
    {
        /// <summary>
        /// Initializes a new instance of the MetricsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public MetricsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            MaxConcurrentviewers = new MaxConcurrentviewersApi(apiClientFactory);
            AvgConcurrentviewers = new AvgConcurrentviewersApi(apiClientFactory);
            AvgDroppedFrames = new AvgDroppedFramesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MetricsApi
        /// </summary>
        public static BitmovinApiBuilder<MetricsApi> Builder => new BitmovinApiBuilder<MetricsApi>();

        /// <summary>
        /// Gets the MaxConcurrentviewers API
        /// </summary>
        public MaxConcurrentviewersApi MaxConcurrentviewers { get; }
        /// <summary>
        /// Gets the AvgConcurrentviewers API
        /// </summary>
        public AvgConcurrentviewersApi AvgConcurrentviewers { get; }
        /// <summary>
        /// Gets the AvgDroppedFrames API
        /// </summary>
        public AvgDroppedFramesApi AvgDroppedFrames { get; }
    }
}
