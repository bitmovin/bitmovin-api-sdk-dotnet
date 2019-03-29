using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.RedundantRtmp
{
    public class RedundantRtmpApi
    {
        private readonly IRedundantRtmpApiClient _apiClient;

        public RedundantRtmpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IRedundantRtmpApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of RedundantRtmpApi
        /// </summary>
        public static BitmovinApiBuilder<RedundantRtmpApi> Builder => new BitmovinApiBuilder<RedundantRtmpApi>();

        
        /// <summary>
        /// Create Redundant RTMP Input
        /// </summary>
        /// <param name="redundantRtmpInput">The request payload</param>
        public async Task<Models.RedundantRtmpInput> CreateAsync(Models.RedundantRtmpInput redundantRtmpInput)
        {
            return await _apiClient.CreateAsync(redundantRtmpInput);
        }
        
        /// <summary>
        /// Delete Redundant RTMP Input
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }
        
        /// <summary>
        /// Redundant RTMP Input Details
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.RedundantRtmpInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }
        
        /// <summary>
        /// List Redundant RTMP Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.RedundantRtmpInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IRedundantRtmpApiClient
        {
            
            [Post("/encoding/inputs/redundant-rtmp")]
            [AllowAnyStatusCode]
            Task<Models.RedundantRtmpInput> CreateAsync([Body] Models.RedundantRtmpInput redundantRtmpInput);
            
            [Delete("/encoding/inputs/redundant-rtmp/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/redundant-rtmp/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.RedundantRtmpInput> GetAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/redundant-rtmp")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.RedundantRtmpInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
