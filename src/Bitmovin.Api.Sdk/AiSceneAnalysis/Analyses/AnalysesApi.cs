using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses.ByEncodingId;

namespace Bitmovin.Api.Sdk.AiSceneAnalysis.Analyses
{
    /// <summary>
    /// API for AnalysesApi
    /// </summary>
    public class AnalysesApi
    {
        private readonly IAnalysesApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AnalysesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AnalysesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAnalysesApiClient>();
            ByEncodingId = new ByEncodingIdApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AnalysesApi
        /// </summary>
        public static BitmovinApiBuilder<AnalysesApi> Builder => new BitmovinApiBuilder<AnalysesApi>();

        /// <summary>
        /// Gets the ByEncodingId API
        /// </summary>
        public ByEncodingIdApi ByEncodingId { get; }

        /// <summary>
        /// List AI Scene Analyses
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SceneAnalysisListItem>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAnalysesApiClient
        {
            [Get("/ai-scene-analysis/analyses")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SceneAnalysisListItem>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Maximum number of items to return. Default is 15, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            /// <summary>
            /// Natural-language text for semantic analysis search. A value containing at least one non-whitespace character enables semantic search and must contain at least 3 characters; omitted, empty, or whitespace-only values use ordinary list behavior
            /// </summary>
            public ListQueryParams SearchText(string searchText) => SetQueryParam("searchText", searchText);

            /// <summary>
            /// Order the results. When searchText is omitted, empty, or whitespace-only, the default is createdAt:DESC and the supported values are createdAt:DESC and createdAt:ASC. When searchText contains at least one non-whitespace character, relevance:DESC is the default and only supported value. Other combinations are rejected
            /// </summary>
            public ListQueryParams Sort(Models.SceneAnalysisListSort sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Inclusive lower creation-date bound in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
            /// </summary>
            public ListQueryParams CreatedAtFrom(DateTime? createdAtFrom) => SetQueryParam("createdAtFrom", createdAtFrom);

            /// <summary>
            /// Inclusive upper creation-date bound in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
            /// </summary>
            public ListQueryParams CreatedAtTo(DateTime? createdAtTo) => SetQueryParam("createdAtTo", createdAtTo);

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
