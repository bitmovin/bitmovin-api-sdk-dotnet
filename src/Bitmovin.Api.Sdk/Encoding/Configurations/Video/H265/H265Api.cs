using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H265.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video.H265
{
    public class H265Api
    {
        private readonly IH265ApiClient _apiClient;

        public H265Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IH265ApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of H265Api
        /// </summary>
        public static BitmovinApiBuilder<H265Api> Builder => new BitmovinApiBuilder<H265Api>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create H265/HEVC Codec Configuration
        /// </summary>
        /// <param name="h265VideoConfiguration">The request payload</param>
        public async Task<Models.H265VideoConfiguration> CreateAsync(Models.H265VideoConfiguration h265VideoConfiguration)
        {
            return await _apiClient.CreateAsync(h265VideoConfiguration);
        }
        
        /// <summary>
        /// Delete H265/HEVC Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }
        
        /// <summary>
        /// H265/HEVC Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.H265VideoConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        /// <summary>
        /// List H265/HEVC Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.H265VideoConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IH265ApiClient
        {
            
            [Post("/encoding/configurations/video/h265")]
            [AllowAnyStatusCode]
            Task<Models.H265VideoConfiguration> CreateAsync([Body] Models.H265VideoConfiguration h265VideoConfiguration);
            
            [Delete("/encoding/configurations/video/h265/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/video/h265/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.H265VideoConfiguration> GetAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/video/h265")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.H265VideoConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
            /// Filter configuration by name
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
