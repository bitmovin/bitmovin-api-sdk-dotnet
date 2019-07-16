using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Metrics.MaxConcurrentviewers;
using Bitmovin.Api.Sdk.Analytics.Metrics.AvgConcurrentviewers;
using Bitmovin.Api.Sdk.Analytics.Metrics.AvgDroppedFrames;

namespace Bitmovin.Api.Sdk.Analytics.Metrics
{
    public class MetricsApi
    {
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

        public MaxConcurrentviewersApi MaxConcurrentviewers { get; private set; }
        public AvgConcurrentviewersApi AvgConcurrentviewers { get; private set; }
        public AvgDroppedFramesApi AvgDroppedFrames { get; private set; }

    }
}
