using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Exports
{
    /// <summary>
    /// API for ExportsApi
    /// </summary>
    public class ExportsApi
    {
        private readonly IExportsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ExportsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ExportsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IExportsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ExportsApi
        /// </summary>
        public static BitmovinApiBuilder<ExportsApi> Builder => new BitmovinApiBuilder<ExportsApi>();

        /// <summary>
        /// Create Export Task
        /// </summary>
        /// <param name="analyticsExportTask">The export task to be created</param>
        public async Task<Models.AnalyticsExportTask> CreateAsync(Models.AnalyticsExportTask analyticsExportTask)
        {
            return await _apiClient.CreateAsync(analyticsExportTask);
        }

        /// <summary>
        /// Get export task
        /// </summary>
        /// <param name="exportTaskId">Export task id (required)</param>
        public async Task<Models.AnalyticsExportTask> GetAsync(string exportTaskId)
        {
            return await _apiClient.GetAsync(exportTaskId);
        }

        /// <summary>
        /// List Export Tasks
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AnalyticsExportTask>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IExportsApiClient
        {
            [Post("/analytics/exports")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsExportTask> CreateAsync([Body] Models.AnalyticsExportTask analyticsExportTask);

            [Get("/analytics/exports/{export_task_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsExportTask> GetAsync([Path("export_task_id")] string exportTaskId);

            [Get("/analytics/exports")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AnalyticsExportTask>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
