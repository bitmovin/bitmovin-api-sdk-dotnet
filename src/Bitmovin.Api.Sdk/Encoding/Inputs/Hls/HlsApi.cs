using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Hls
{
    /// <summary>
    /// API for HlsApi
    /// </summary>
    public class HlsApi
    {
        private readonly IHlsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the HlsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public HlsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHlsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of HlsApi
        /// </summary>
        public static BitmovinApiBuilder<HlsApi> Builder => new BitmovinApiBuilder<HlsApi>();

        /// <summary>
        /// Create HLS input
        /// </summary>
        /// <param name="hlsInput">The HLSInput to be created</param>
        public async Task<Models.HlsInput> CreateAsync(Models.HlsInput hlsInput)
        {
            return await _apiClient.CreateAsync(hlsInput);
        }

        /// <summary>
        /// Delete HLS Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.HlsInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// HLS Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.HlsInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List HLS inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.HlsInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IHlsApiClient
        {
            [Post("/encoding/inputs/hls")]
            [AllowAnyStatusCode]
            Task<Models.HlsInput> CreateAsync([Body] Models.HlsInput hlsInput);

            [Delete("/encoding/inputs/hls/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.HlsInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/hls/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.HlsInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/hls")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.HlsInput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Filter inputs by name
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
