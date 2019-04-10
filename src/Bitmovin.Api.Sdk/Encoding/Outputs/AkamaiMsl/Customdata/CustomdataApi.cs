using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiMsl.Customdata
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
        /// Akamai MSL Output Custom Data
        /// </summary>
        /// <param name="outputId">Id of the output</param>
        public async Task<Models.CustomData> GetCustomDataAsync(string outputId)
        {
            return await _apiClient.GetCustomDataAsync(outputId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/outputs/akamai-msl/{output_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataAsync([Path("output_id")] string outputId);
            
        }
        
    }
}
