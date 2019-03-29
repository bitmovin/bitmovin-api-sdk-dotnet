using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Unsharp.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Unsharp
{
    public class UnsharpApi
    {
        private readonly IUnsharpApiClient _apiClient;

        public UnsharpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IUnsharpApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of UnsharpApi
        /// </summary>
        public static BitmovinApiBuilder<UnsharpApi> Builder => new BitmovinApiBuilder<UnsharpApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Unsharp Filter
        /// </summary>
        /// <param name="unsharpFilter">The request payload</param>
        public async Task<Models.UnsharpFilter> CreateAsync(Models.UnsharpFilter unsharpFilter)
        {
            return await _apiClient.CreateAsync(unsharpFilter);
        }
        
        /// <summary>
        /// Delete Unsharp Filter
        /// </summary>
        /// <param name="filterId">Id of the unsharp filter</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }
        
        /// <summary>
        /// Unsharp Filter Details
        /// </summary>
        /// <param name="filterId">Id of the unsharp filter</param>
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
            Task<Models.PaginationResponse<Models.UnsharpFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

            /// <summary>
            /// Filter filters by name
            /// </summary>
            public ListQueryParams Name(string Name) => SetQueryParam("name", Name);

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
