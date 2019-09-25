using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp2.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp2
{
    public class Mp2Api
    {
        private readonly IMp2ApiClient _apiClient;

        public Mp2Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMp2ApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Mp2Api
        /// </summary>
        public static BitmovinApiBuilder<Mp2Api> Builder => new BitmovinApiBuilder<Mp2Api>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create MP2 Codec Configuration
        /// </summary>
        /// <param name="mp2AudioConfiguration">The request payload</param>
        public async Task<Models.Mp2AudioConfiguration> CreateAsync(Models.Mp2AudioConfiguration mp2AudioConfiguration)
        {
            return await _apiClient.CreateAsync(mp2AudioConfiguration);
        }
        
        /// <summary>
        /// Delete MP2 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }
        
        /// <summary>
        /// MP2 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.Mp2AudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        internal interface IMp2ApiClient
        {
            
            [Post("/encoding/configurations/audio/mp2")]
            [AllowAnyStatusCode]
            Task<Models.Mp2AudioConfiguration> CreateAsync([Body] Models.Mp2AudioConfiguration mp2AudioConfiguration);
            
            [Delete("/encoding/configurations/audio/mp2/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/audio/mp2/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.Mp2AudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);
            
        }
        
    }
}
