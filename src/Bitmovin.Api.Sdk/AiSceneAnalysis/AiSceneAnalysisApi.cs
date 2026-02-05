using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis
{
    /// <summary>
    /// API for AiSceneAnalysisApi
    /// </summary>
    public class AiSceneAnalysisApi
    {
        /// <summary>
        /// Initializes a new instance of the AiSceneAnalysisApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AiSceneAnalysisApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Analyses = new AnalysesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AiSceneAnalysisApi
        /// </summary>
        public static BitmovinApiBuilder<AiSceneAnalysisApi> Builder => new BitmovinApiBuilder<AiSceneAnalysisApi>();

        /// <summary>
        /// Gets the Analyses API
        /// </summary>
        public AnalysesApi Analyses { get; }
    }
}
