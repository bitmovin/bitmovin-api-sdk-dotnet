using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.LiveAnalyses.Results;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.LiveAnalyses
{
    /// <summary>
    /// API for LiveAnalysesApi
    /// </summary>
    public class LiveAnalysesApi
    {
        private readonly ILiveAnalysesApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the LiveAnalysesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public LiveAnalysesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveAnalysesApiClient>();
            Results = new ResultsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveAnalysesApi
        /// </summary>
        public static BitmovinApiBuilder<LiveAnalysesApi> Builder => new BitmovinApiBuilder<LiveAnalysesApi>();

        /// <summary>
        /// Gets the Results API
        /// </summary>
        public ResultsApi Results { get; }

        /// <summary>
        /// Create Live Analysis
        /// </summary>
        /// <param name="aiSceneAnalysisLiveCreateRequest">Live Analysis configuration</param>
        public async Task<Models.AiSceneAnalysisLiveResponse> CreateAsync(Models.AiSceneAnalysisLiveCreateRequest aiSceneAnalysisLiveCreateRequest)
        {
            return await _apiClient.CreateAsync(aiSceneAnalysisLiveCreateRequest);
        }

        /// <summary>
        /// Delete Live Analysis
        /// </summary>
        /// <param name="analysisId">ID of the Live Analysis (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string analysisId)
        {
            return await _apiClient.DeleteAsync(analysisId);
        }

        /// <summary>
        /// Get Live Analysis details
        /// </summary>
        /// <param name="analysisId">ID of the Live Analysis (required)</param>
        public async Task<Models.AiSceneAnalysisLiveResponse> GetAsync(string analysisId)
        {
            return await _apiClient.GetAsync(analysisId);
        }

        /// <summary>
        /// List Live Analyses
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AiSceneAnalysisLiveResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Start Live Analysis
        /// </summary>
        /// <param name="analysisId">ID of the Live Analysis (required)</param>
        public async Task<Models.AiSceneAnalysisLiveResponse> StartAsync(string analysisId)
        {
            return await _apiClient.StartAsync(analysisId);
        }

        /// <summary>
        /// Stop Live Analysis
        /// </summary>
        /// <param name="analysisId">ID of the Live Analysis (required)</param>
        public async Task<Models.AiSceneAnalysisLiveResponse> StopAsync(string analysisId)
        {
            return await _apiClient.StopAsync(analysisId);
        }

        internal interface ILiveAnalysesApiClient
        {
            [Post("/ai-scene-analysis/live-analyses")]
            [AllowAnyStatusCode]
            Task<Models.AiSceneAnalysisLiveResponse> CreateAsync([Body] Models.AiSceneAnalysisLiveCreateRequest aiSceneAnalysisLiveCreateRequest);

            [Delete("/ai-scene-analysis/live-analyses/{analysis_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("analysis_id")] string analysisId);

            [Get("/ai-scene-analysis/live-analyses/{analysis_id}")]
            [AllowAnyStatusCode]
            Task<Models.AiSceneAnalysisLiveResponse> GetAsync([Path("analysis_id")] string analysisId);

            [Get("/ai-scene-analysis/live-analyses")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AiSceneAnalysisLiveResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/ai-scene-analysis/live-analyses/{analysis_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.AiSceneAnalysisLiveResponse> StartAsync([Path("analysis_id")] string analysisId);

            [Post("/ai-scene-analysis/live-analyses/{analysis_id}/stop")]
            [AllowAnyStatusCode]
            Task<Models.AiSceneAnalysisLiveResponse> StopAsync([Path("analysis_id")] string analysisId);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}
