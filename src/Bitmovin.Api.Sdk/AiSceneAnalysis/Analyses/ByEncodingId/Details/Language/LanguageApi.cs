using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Details.Language
{
    /// <summary>
    /// API for LanguageApi
    /// </summary>
    public class LanguageApi
    {
        private readonly ILanguageApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the LanguageApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public LanguageApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILanguageApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of LanguageApi
        /// </summary>
        public static BitmovinApiBuilder<LanguageApi> Builder => new BitmovinApiBuilder<LanguageApi>();

        /// <summary>
        /// Get translated AI scene analysis details by encoding ID and language code
        /// </summary>
        /// <param name="encodingId">The encoding ID (required)</param>
        /// <param name="languageCode">The language code (required)</param>
        public async Task<Models.SceneAnalysisDetailsResponse> GetAsync(string encodingId, string languageCode)
        {
            return await _apiClient.GetAsync(encodingId, languageCode);
        }

        internal interface ILanguageApiClient
        {
            [Get("/ai-scene-analysis/analyses/by-encoding-id/{encoding_id}/details/language/{language_code}")]
            [AllowAnyStatusCode]
            Task<Models.SceneAnalysisDetailsResponse> GetAsync([Path("encoding_id")] string encodingId, [Path("language_code")] string languageCode);
        }
    }
}
