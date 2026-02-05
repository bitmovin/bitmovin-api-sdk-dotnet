using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Unsharp.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Unsharp
{
    /// <summary>
    /// API for UnsharpApi
    /// </summary>
    public class UnsharpApi
    {
        private readonly IUnsharpApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the UnsharpApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public UnsharpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IUnsharpApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of UnsharpApi
        /// </summary>
        public static BitmovinApiBuilder<UnsharpApi> Builder => new BitmovinApiBuilder<UnsharpApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Unsharp Filter
        /// </summary>
        /// <param name="unsharpFilter">The Unsharp Filter to be created</param>
        public async Task<Models.UnsharpFilter> CreateAsync(Models.UnsharpFilter unsharpFilter)
        {
            return await _apiClient.CreateAsync(unsharpFilter);
        }

        /// <summary>
        /// Delete Unsharp Filter
        /// </summary>
        /// <param name="filterId">Id of the unsharp filter (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Unsharp Filter Details
        /// </summary>
        /// <param name="filterId">Id of the unsharp filter (required)</param>
        public async Task<Models.UnsharpFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Unsharp Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.UnsharpFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IUnsharpApiClient
        {
            [Post("/encoding/filters/unsharp")]
            [AllowAnyStatusCode]
            Task<Models.UnsharpFilter> CreateAsync([Body] Models.UnsharpFilter unsharpFilter);

            [Delete("/encoding/filters/unsharp/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/unsharp/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.UnsharpFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/unsharp")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.UnsharpFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Filter filters by name
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
