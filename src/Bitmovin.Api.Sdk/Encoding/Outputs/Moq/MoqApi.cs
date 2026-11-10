using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.Moq.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.Moq
{
    /// <summary>
    /// API for MoqApi
    /// </summary>
    public class MoqApi
    {
        private readonly IMoqApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the MoqApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public MoqApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMoqApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MoqApi
        /// </summary>
        public static BitmovinApiBuilder<MoqApi> Builder => new BitmovinApiBuilder<MoqApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create MoQ Output
        /// </summary>
        /// <param name="moqOutput">The MoQ output to be created</param>
        public async Task<Models.MoqOutput> CreateAsync(Models.MoqOutput moqOutput)
        {
            return await _apiClient.CreateAsync(moqOutput);
        }

        /// <summary>
        /// Delete MoQ Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// Get MoQ Output details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.MoqOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List MoQ Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.MoqOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IMoqApiClient
        {
            [Post("/encoding/outputs/moq")]
            [AllowAnyStatusCode]
            Task<Models.MoqOutput> CreateAsync([Body] Models.MoqOutput moqOutput);

            [Delete("/encoding/outputs/moq/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/moq/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.MoqOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/moq")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.MoqOutput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
