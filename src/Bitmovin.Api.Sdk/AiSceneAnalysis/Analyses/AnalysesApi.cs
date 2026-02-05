using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses
{
    /// <summary>
    /// API for AnalysesApi
    /// </summary>
    public class AnalysesApi
    {
        /// <summary>
        /// Initializes a new instance of the AnalysesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AnalysesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            ByEncodingId = new ByEncodingIdApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AnalysesApi
        /// </summary>
        public static BitmovinApiBuilder<AnalysesApi> Builder => new BitmovinApiBuilder<AnalysesApi>();

        /// <summary>
        /// Gets the ByEncodingId API
        /// </summary>
        public ByEncodingIdApi ByEncodingId { get; }
    }
}
