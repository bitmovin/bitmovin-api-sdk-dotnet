using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Details.Language;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Details
{
    public class DetailsApi
    {
        private readonly IDetailsApiClient _apiClient;

        public DetailsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDetailsApiClient>();
            Language = new LanguageApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DetailsApi
        /// </summary>
        public static BitmovinApiBuilder<DetailsApi> Builder => new BitmovinApiBuilder<DetailsApi>();

        public LanguageApi Language { get; }

        /// <summary>
        /// Get AI scene analysis details by encoding ID
        /// </summary>
        /// <param name="encodingId">The encoding ID (required)</param>
        public async Task<Models.SceneAnalysisDetailsResponse> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface IDetailsApiClient
        {
            [Get("/ai-scene-analysis/analyses/by-encoding-id/{encoding_id}/details")]
            [AllowAnyStatusCode]
            Task<Models.SceneAnalysisDetailsResponse> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
