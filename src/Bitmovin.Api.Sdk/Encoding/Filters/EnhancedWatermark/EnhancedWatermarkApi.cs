using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.EnhancedWatermark.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.EnhancedWatermark
{
    public class EnhancedWatermarkApi
    {
        private readonly IEnhancedWatermarkApiClient _apiClient;

        public EnhancedWatermarkApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEnhancedWatermarkApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EnhancedWatermarkApi
        /// </summary>
        public static BitmovinApiBuilder<EnhancedWatermarkApi> Builder => new BitmovinApiBuilder<EnhancedWatermarkApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Enhanced Watermark Filter
        /// </summary>
        /// <param name="enhancedWatermarkFilter">The request payload</param>
        public async Task<Models.EnhancedWatermarkFilter> CreateAsync(Models.EnhancedWatermarkFilter enhancedWatermarkFilter)
        {
            return await _apiClient.CreateAsync(enhancedWatermarkFilter);
        }
        
        /// <summary>
        /// Delete Enhanced Watermark Filter
        /// </summary>
        /// <param name="filterId">Id of the enhanced watermark configuration.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }
        
        /// <summary>
        /// Enhanced Watermark Filter Details
        /// </summary>
        /// <param name="filterId">Id of the enhanced watermark configuration.</param>
        public async Task<Models.EnhancedWatermarkFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }
        
        /// <summary>
        /// List Enhanced Watermark Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EnhancedWatermarkFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IEnhancedWatermarkApiClient
        {
            
            [Post("/encoding/filters/enhanced-watermark")]
            [AllowAnyStatusCode]
            Task<Models.EnhancedWatermarkFilter> CreateAsync([Body] Models.EnhancedWatermarkFilter enhancedWatermarkFilter);
            
            [Delete("/encoding/filters/enhanced-watermark/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);
            
            [Get("/encoding/filters/enhanced-watermark/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.EnhancedWatermarkFilter> GetAsync([Path("filter_id")] string filterId);
            
            [Get("/encoding/filters/enhanced-watermark")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EnhancedWatermarkFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
