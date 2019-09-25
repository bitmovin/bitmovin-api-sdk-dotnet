using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Conform.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Conform
{
    public class ConformApi
    {
        private readonly IConformApiClient _apiClient;

        public ConformApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IConformApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ConformApi
        /// </summary>
        public static BitmovinApiBuilder<ConformApi> Builder => new BitmovinApiBuilder<ConformApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Conform Filter. Keeps all the frames of the input. The playback time of the output will be slower or faster.
        /// </summary>
        /// <param name="conformFilter">The request payload</param>
        public async Task<Models.ConformFilter> CreateAsync(Models.ConformFilter conformFilter)
        {
            return await _apiClient.CreateAsync(conformFilter);
        }
        
        /// <summary>
        /// Delete Conform Filter
        /// </summary>
        /// <param name="filterId">Id of the conform filter</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }
        
        /// <summary>
        /// Conform Filter Details
        /// </summary>
        /// <param name="filterId">Id of the conform filter</param>
        public async Task<Models.ConformFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }
        
        /// <summary>
        /// List Conform Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ConformFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IConformApiClient
        {
            
            [Post("/encoding/filters/conform")]
            [AllowAnyStatusCode]
            Task<Models.ConformFilter> CreateAsync([Body] Models.ConformFilter conformFilter);
            
            [Delete("/encoding/filters/conform/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);
            
            [Get("/encoding/filters/conform/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.ConformFilter> GetAsync([Path("filter_id")] string filterId);
            
            [Get("/encoding/filters/conform")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ConformFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
