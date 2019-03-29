using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Ac3.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Ac3
{
    public class Ac3Api
    {
        private readonly IAc3ApiClient _apiClient;

        public Ac3Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAc3ApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Ac3Api
        /// </summary>
        public static BitmovinApiBuilder<Ac3Api> Builder => new BitmovinApiBuilder<Ac3Api>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create AC3 Codec Configuration
        /// </summary>
        /// <param name="ac3AudioConfiguration">The request payload</param>
        public async Task<Models.Ac3AudioConfiguration> CreateAsync(Models.Ac3AudioConfiguration ac3AudioConfiguration)
        {
            return await _apiClient.CreateAsync(ac3AudioConfiguration);
        }
        
        /// <summary>
        /// Delete AC3 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }
        
        /// <summary>
        /// AC3 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.Ac3AudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        /// <summary>
        /// List AC3 Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Ac3AudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IAc3ApiClient
        {
            
            [Post("/encoding/configurations/audio/ac3")]
            [AllowAnyStatusCode]
            Task<Models.Ac3AudioConfiguration> CreateAsync([Body] Models.Ac3AudioConfiguration ac3AudioConfiguration);
            
            [Delete("/encoding/configurations/audio/ac3/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/audio/ac3/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.Ac3AudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/audio/ac3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Ac3AudioConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
