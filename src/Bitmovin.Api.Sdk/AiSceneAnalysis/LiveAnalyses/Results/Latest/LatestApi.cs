using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.LiveAnalyses.Results.Latest
{
    /// <summary>
    /// API for LatestApi
    /// </summary>
    public class LatestApi
    {
        private readonly ILatestApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the LatestApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public LatestApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILatestApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of LatestApi
        /// </summary>
        public static BitmovinApiBuilder<LatestApi> Builder => new BitmovinApiBuilder<LatestApi>();

        /// <summary>
        /// Get Live Analysis Latest Result
        /// </summary>
        /// <param name="analysisId">ID of the Live Analysis (required)</param>
        public async Task<Models.AiSceneAnalysisLiveResult> GetAsync(string analysisId)
        {
            return await _apiClient.GetAsync(analysisId);
        }

        internal interface ILatestApiClient
        {
            [Get("/ai-scene-analysis/live-analyses/{analysis_id}/results/latest")]
            [AllowAnyStatusCode]
            Task<Models.AiSceneAnalysisLiveResult> GetAsync([Path("analysis_id")] string analysisId);
        }
    }
}
