using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.Local.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.Local
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
        /// Create Local Output
        /// </summary>
        /// <param name="localOutput">The request payload</param>
        public async Task<Models.LocalOutput> CreateAsync(Models.LocalOutput localOutput)
        {
            return await _apiClient.CreateAsync(localOutput);
        }
        
        /// <summary>
        /// Delete Local Output
        /// </summary>
        /// <param name="outputId">Id of the output</param>
        public async Task<Models.LocalOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }
        
        /// <summary>
        /// Local Output Details
        /// </summary>
        /// <param name="outputId">Id of the output</param>
        public async Task<Models.LocalOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }
        
        /// <summary>
        /// List Local Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.LocalOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            
            [Post("/encoding/outputs/local")]
            [AllowAnyStatusCode]
            Task<Models.LocalOutput> CreateAsync([Body] Models.LocalOutput localOutput);
            
            [Delete("/encoding/outputs/local/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.LocalOutput> DeleteAsync([Path("output_id")] string outputId);
            
            [Get("/encoding/outputs/local/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.LocalOutput> GetAsync([Path("output_id")] string outputId);
            
            [Get("/encoding/outputs/local")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.LocalOutput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
            /// Filter output by name
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
