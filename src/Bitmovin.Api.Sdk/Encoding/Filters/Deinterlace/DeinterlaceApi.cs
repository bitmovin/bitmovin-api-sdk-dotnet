using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Deinterlace.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Deinterlace
{
    public class DeinterlaceApi
    {
        private readonly IDeinterlaceApiClient _apiClient;

        public DeinterlaceApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDeinterlaceApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DeinterlaceApi
        /// </summary>
        public static BitmovinApiBuilder<DeinterlaceApi> Builder => new BitmovinApiBuilder<DeinterlaceApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Deinterlace Filter
        /// </summary>
        /// <param name="deinterlaceFilter">The request payload</param>
        public async Task<Models.DeinterlaceFilter> CreateAsync(Models.DeinterlaceFilter deinterlaceFilter)
        {
            return await _apiClient.CreateAsync(deinterlaceFilter);
        }
        
        /// <summary>
        /// Delete Deinterlace Filter
        /// </summary>
        /// <param name="filterId">Id of the deinterlace filter</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }
        
        /// <summary>
        /// Deinterlace Filter Details
        /// </summary>
        /// <param name="filterId">Id of the deinterlace filter</param>
        public async Task<Models.DeinterlaceFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }
        
        /// <summary>
        /// List Deinterlace Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DeinterlaceFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IDeinterlaceApiClient
        {
            
            [Post("/encoding/filters/deinterlace")]
            [AllowAnyStatusCode]
            Task<Models.DeinterlaceFilter> CreateAsync([Body] Models.DeinterlaceFilter deinterlaceFilter);
            
            [Delete("/encoding/filters/deinterlace/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);
            
            [Get("/encoding/filters/deinterlace/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.DeinterlaceFilter> GetAsync([Path("filter_id")] string filterId);
            
            [Get("/encoding/filters/deinterlace")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DeinterlaceFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
