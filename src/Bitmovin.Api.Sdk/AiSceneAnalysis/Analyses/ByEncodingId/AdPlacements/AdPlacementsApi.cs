using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.AdPlacements
{
    /// <summary>
    /// API for AdPlacementsApi
    /// </summary>
    public class AdPlacementsApi
    {
        private readonly IAdPlacementsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AdPlacementsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AdPlacementsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAdPlacementsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of AdPlacementsApi
        /// </summary>
        public static BitmovinApiBuilder<AdPlacementsApi> Builder => new BitmovinApiBuilder<AdPlacementsApi>();

        /// <summary>
        /// Get AI scene analysis ad placements by encoding ID
        /// </summary>
        /// <param name="encodingId">The encoding ID (required)</param>
        public async Task<Models.SceneAnalysisAdPlacementMetadataResponse> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface IAdPlacementsApiClient
        {
            [Get("/ai-scene-analysis/analyses/by-encoding-id/{encoding_id}/ad-placements")]
            [AllowAnyStatusCode]
            Task<Models.SceneAnalysisAdPlacementMetadataResponse> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
