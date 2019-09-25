using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Zixi.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Zixi
{
    public class ZixiApi
    {
        private readonly IZixiApiClient _apiClient;

        public ZixiApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IZixiApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ZixiApi
        /// </summary>
        public static BitmovinApiBuilder<ZixiApi> Builder => new BitmovinApiBuilder<ZixiApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Zixi input
        /// </summary>
        /// <param name="zixiInput">The request payload</param>
        public async Task<Models.ZixiInput> CreateAsync(Models.ZixiInput zixiInput)
        {
            return await _apiClient.CreateAsync(zixiInput);
        }
        
        /// <summary>
        /// Delete Zixi input
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.ZixiInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }
        
        /// <summary>
        /// Zixi Input Details
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.ZixiInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }
        
        /// <summary>
        /// List Zixi inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ZixiInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IZixiApiClient
        {
            
            [Post("/encoding/inputs/zixi")]
            [AllowAnyStatusCode]
            Task<Models.ZixiInput> CreateAsync([Body] Models.ZixiInput zixiInput);
            
            [Delete("/encoding/inputs/zixi/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.ZixiInput> DeleteAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/zixi/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.ZixiInput> GetAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/zixi")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ZixiInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
