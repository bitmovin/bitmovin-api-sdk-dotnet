using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Scale.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Scale
{
    public class ScaleApi
    {
        private readonly IScaleApiClient _apiClient;

        public ScaleApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IScaleApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ScaleApi
        /// </summary>
        public static BitmovinApiBuilder<ScaleApi> Builder => new BitmovinApiBuilder<ScaleApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Scale Filter
        /// </summary>
        /// <param name="scaleFilter">The request payload</param>
        public async Task<Models.ScaleFilter> CreateAsync(Models.ScaleFilter scaleFilter)
        {
            return await _apiClient.CreateAsync(scaleFilter);
        }
        
        /// <summary>
        /// Delete Scale Filter
        /// </summary>
        /// <param name="filterId">Id of the scale filter</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }
        
        /// <summary>
        /// Scale Filter Details
        /// </summary>
        /// <param name="filterId">Id of the scale filter</param>
        public async Task<Models.ScaleFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }
        
        /// <summary>
        /// List Scale Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ScaleFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IScaleApiClient
        {
            
            [Post("/encoding/filters/scale")]
            [AllowAnyStatusCode]
            Task<Models.ScaleFilter> CreateAsync([Body] Models.ScaleFilter scaleFilter);
            
            [Delete("/encoding/filters/scale/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);
            
            [Get("/encoding/filters/scale/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.ScaleFilter> GetAsync([Path("filter_id")] string filterId);
            
            [Get("/encoding/filters/scale")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ScaleFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
