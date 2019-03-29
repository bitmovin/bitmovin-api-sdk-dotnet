using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Local.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Local
{
    public class LocalApi
    {
        private readonly ILocalApiClient _apiClient;

        public LocalApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILocalApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LocalApi
        /// </summary>
        public static BitmovinApiBuilder<LocalApi> Builder => new BitmovinApiBuilder<LocalApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Local Input
        /// </summary>
        /// <param name="localInput">The request payload</param>
        public async Task<Models.LocalInput> CreateAsync(Models.LocalInput localInput)
        {
            return await _apiClient.CreateAsync(localInput);
        }
        
        /// <summary>
        /// Delete Local Input
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.LocalInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }
        
        /// <summary>
        /// Local Input Details
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.LocalInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }
        
        /// <summary>
        /// List Local Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.LocalInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface ILocalApiClient
        {
            
            [Post("/encoding/inputs/local")]
            [AllowAnyStatusCode]
            Task<Models.LocalInput> CreateAsync([Body] Models.LocalInput localInput);
            
            [Delete("/encoding/inputs/local/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.LocalInput> DeleteAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/local/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.LocalInput> GetAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/local")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.LocalInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
            /// Filter inputs by name
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
