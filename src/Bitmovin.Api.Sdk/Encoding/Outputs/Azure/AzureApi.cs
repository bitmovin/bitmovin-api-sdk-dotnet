using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.Azure.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.Azure
{
    public class AzureApi
    {
        private readonly IAzureApiClient _apiClient;

        public AzureApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAzureApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AzureApi
        /// </summary>
        public static BitmovinApiBuilder<AzureApi> Builder => new BitmovinApiBuilder<AzureApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Azure Output
        /// </summary>
        /// <param name="azureOutput">The Azure output to be created</param>
        public async Task<Models.AzureOutput> CreateAsync(Models.AzureOutput azureOutput)
        {
            return await _apiClient.CreateAsync(azureOutput);
        }

        /// <summary>
        /// Delete Azure Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.AzureOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// Azure Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.AzureOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List Azure Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AzureOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/outputs/azure")]
            [AllowAnyStatusCode]
            Task<Models.AzureOutput> CreateAsync([Body] Models.AzureOutput azureOutput);

            [Delete("/encoding/outputs/azure/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.AzureOutput> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/azure/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.AzureOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/azure")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AzureOutput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

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
