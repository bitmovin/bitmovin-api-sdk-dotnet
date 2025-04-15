using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis
{
    public class AiSceneAnalysisApi
    {
        public AiSceneAnalysisApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Analyses = new AnalysesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AiSceneAnalysisApi
        /// </summary>
        public static BitmovinApiBuilder<AiSceneAnalysisApi> Builder => new BitmovinApiBuilder<AiSceneAnalysisApi>();

        public AnalysesApi Analyses { get; }
    }
}
