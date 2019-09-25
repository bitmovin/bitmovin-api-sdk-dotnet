using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV2.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV2
{
    public class HeAacV2Api
    {
        private readonly IHeAacV2ApiClient _apiClient;

        public HeAacV2Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHeAacV2ApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of HeAacV2Api
        /// </summary>
        public static BitmovinApiBuilder<HeAacV2Api> Builder => new BitmovinApiBuilder<HeAacV2Api>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create HE-AAC v2 Codec Configuration
        /// </summary>
        /// <param name="heAacV2AudioConfiguration">The request payload</param>
        public async Task<Models.HeAacV2AudioConfiguration> CreateAsync(Models.HeAacV2AudioConfiguration heAacV2AudioConfiguration)
        {
            return await _apiClient.CreateAsync(heAacV2AudioConfiguration);
        }
        
        /// <summary>
        /// Delete HE-AAC v2 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }
        
        /// <summary>
        /// HE-AAC v2 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.HeAacV2AudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        /// <summary>
        /// List HE-AAC v2 Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.HeAacV2AudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IHeAacV2ApiClient
        {
            
            [Post("/encoding/configurations/audio/he-aac-v2")]
            [AllowAnyStatusCode]
            Task<Models.HeAacV2AudioConfiguration> CreateAsync([Body] Models.HeAacV2AudioConfiguration heAacV2AudioConfiguration);
            
            [Delete("/encoding/configurations/audio/he-aac-v2/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/audio/he-aac-v2/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.HeAacV2AudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/audio/he-aac-v2")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.HeAacV2AudioConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
