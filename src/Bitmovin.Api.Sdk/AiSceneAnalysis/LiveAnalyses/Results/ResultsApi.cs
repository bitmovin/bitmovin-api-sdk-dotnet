using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.LiveAnalyses.Results.Latest;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.LiveAnalyses.Results
{
    /// <summary>
    /// API for ResultsApi
    /// </summary>
    public class ResultsApi
    {
        /// <summary>
        /// Initializes a new instance of the ResultsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ResultsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Latest = new LatestApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ResultsApi
        /// </summary>
        public static BitmovinApiBuilder<ResultsApi> Builder => new BitmovinApiBuilder<ResultsApi>();

        /// <summary>
        /// Gets the Latest API
        /// </summary>
        public LatestApi Latest { get; }
    }
}
