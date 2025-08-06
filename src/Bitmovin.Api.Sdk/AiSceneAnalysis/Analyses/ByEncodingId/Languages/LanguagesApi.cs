using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId.Languages
{
    public class LanguagesApi
    {
        private readonly ILanguagesApiClient _apiClient;

        public LanguagesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILanguagesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of LanguagesApi
        /// </summary>
        public static BitmovinApiBuilder<LanguagesApi> Builder => new BitmovinApiBuilder<LanguagesApi>();

        /// <summary>
        /// Get AI scene analysis languages by encoding ID
        /// </summary>
        /// <param name="encodingId">The encoding ID (required)</param>
        public async Task<Models.SceneAnalysisLanguagesResponse> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface ILanguagesApiClient
        {
            [Get("/ai-scene-analysis/analyses/by-encoding-id/{encoding_id}/languages")]
            [AllowAnyStatusCode]
            Task<Models.SceneAnalysisLanguagesResponse> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
