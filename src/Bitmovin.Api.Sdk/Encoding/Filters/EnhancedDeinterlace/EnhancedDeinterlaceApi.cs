using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.EnhancedDeinterlace.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.EnhancedDeinterlace
{
    public class EnhancedDeinterlaceApi
    {
        private readonly IEnhancedDeinterlaceApiClient _apiClient;

        public EnhancedDeinterlaceApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEnhancedDeinterlaceApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EnhancedDeinterlaceApi
        /// </summary>
        public static BitmovinApiBuilder<EnhancedDeinterlaceApi> Builder => new BitmovinApiBuilder<EnhancedDeinterlaceApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Enhanced Deinterlace Filter
        /// </summary>
        /// <param name="enhancedDeinterlaceFilter">The Enhanced Deinterlace Filter to be created</param>
        public async Task<Models.EnhancedDeinterlaceFilter> CreateAsync(Models.EnhancedDeinterlaceFilter enhancedDeinterlaceFilter)
        {
            return await _apiClient.CreateAsync(enhancedDeinterlaceFilter);
        }

        /// <summary>
        /// Delete Enhanced Deinterlace Filter
        /// </summary>
        /// <param name="filterId">Id of the Enhanced Deinterlace Filter (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Enhanced Deinterlace Filter Details
        /// </summary>
        /// <param name="filterId">Id of the Enhanced Deinterlace Filter (required)</param>
        public async Task<Models.EnhancedDeinterlaceFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Enhanced Deinterlace Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EnhancedDeinterlaceFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IEnhancedDeinterlaceApiClient
        {
            [Post("/encoding/filters/enhanced-deinterlace")]
            [AllowAnyStatusCode]
            Task<Models.EnhancedDeinterlaceFilter> CreateAsync([Body] Models.EnhancedDeinterlaceFilter enhancedDeinterlaceFilter);

            [Delete("/encoding/filters/enhanced-deinterlace/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/enhanced-deinterlace/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.EnhancedDeinterlaceFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/enhanced-deinterlace")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EnhancedDeinterlaceFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
