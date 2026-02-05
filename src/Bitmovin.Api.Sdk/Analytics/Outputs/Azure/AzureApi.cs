using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Outputs.Azure.Customdata;

namespace Bitmovin.Api.Sdk.Analytics.Outputs.Azure
{
    /// <summary>
    /// API for AzureApi
    /// </summary>
    public class AzureApi
    {
        private readonly IAzureApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AzureApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AzureApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAzureApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AzureApi
        /// </summary>
        public static BitmovinApiBuilder<AzureApi> Builder => new BitmovinApiBuilder<AzureApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Microsoft Azure Output
        /// </summary>
        /// <param name="analyticsAzureOutput">The Microsoft Azure output to be created</param>
        public async Task<Models.AnalyticsAzureOutput> CreateAsync(Models.AnalyticsAzureOutput analyticsAzureOutput)
        {
            return await _apiClient.CreateAsync(analyticsAzureOutput);
        }

        /// <summary>
        /// Delete Microsoft Azure Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.AnalyticsAzureOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// Microsoft Azure Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.AnalyticsAzureOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List Microsoft Azure Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AnalyticsAzureOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAzureApiClient
        {
            [Post("/analytics/outputs/azure")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAzureOutput> CreateAsync([Body] Models.AnalyticsAzureOutput analyticsAzureOutput);

            [Delete("/analytics/outputs/azure/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAzureOutput> DeleteAsync([Path("output_id")] string outputId);

            [Get("/analytics/outputs/azure/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsAzureOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/analytics/outputs/azure")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AnalyticsAzureOutput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

            /// <summary>
            /// Filter output by name
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

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
