using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Vp9.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video.Vp9
{
    public class Vp9Api
    {
        private readonly IVp9ApiClient _apiClient;

        public Vp9Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVp9ApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Vp9Api
        /// </summary>
        public static BitmovinApiBuilder<Vp9Api> Builder => new BitmovinApiBuilder<Vp9Api>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create VP9 Codec Configuration
        /// </summary>
        /// <param name="vp9VideoConfiguration">The request payload</param>
        public async Task<Models.Vp9VideoConfiguration> CreateAsync(Models.Vp9VideoConfiguration vp9VideoConfiguration)
        {
            return await _apiClient.CreateAsync(vp9VideoConfiguration);
        }
        
        /// <summary>
        /// Delete VP9 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }
        
        /// <summary>
        /// VP9 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.Vp9VideoConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        /// <summary>
        /// List VP9 Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Vp9VideoConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IVp9ApiClient
        {
            
            [Post("/encoding/configurations/video/vp9")]
            [AllowAnyStatusCode]
            Task<Models.Vp9VideoConfiguration> CreateAsync([Body] Models.Vp9VideoConfiguration vp9VideoConfiguration);
            
            [Delete("/encoding/configurations/video/vp9/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/video/vp9/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.Vp9VideoConfiguration> GetAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/video/vp9")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Vp9VideoConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
