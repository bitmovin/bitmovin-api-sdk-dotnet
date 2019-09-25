using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV1.Customdata
{
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        
        /// <summary>
        /// HE-AAC v1 Codec Configuration Custom Data
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.CustomData> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/configurations/audio/he-aac-v1/{configuration_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("configuration_id")] string configurationId);
            
        }
        
    }
}
