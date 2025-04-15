using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses
{
    public class AnalysesApi
    {
        public AnalysesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            ByEncodingId = new ByEncodingIdApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AnalysesApi
        /// </summary>
        public static BitmovinApiBuilder<AnalysesApi> Builder => new BitmovinApiBuilder<AnalysesApi>();

        public ByEncodingIdApi ByEncodingId { get; }
    }
}
