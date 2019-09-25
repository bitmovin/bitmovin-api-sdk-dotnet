using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Type
{
    public class TypeApi
    {
        private readonly ITypeApiClient _apiClient;

        public TypeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITypeApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of TypeApi
        /// </summary>
        public static BitmovinApiBuilder<TypeApi> Builder => new BitmovinApiBuilder<TypeApi>();

        
        /// <summary>
        /// Get Codec Configuration Type
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.CodecConfigTypeResponse> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        internal interface ITypeApiClient
        {
            
            [Get("/encoding/configurations/{configuration_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.CodecConfigTypeResponse> GetAsync([Path("configuration_id")] string configurationId);
            
        }
        
    }
}
