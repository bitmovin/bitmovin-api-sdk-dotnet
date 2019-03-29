using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.Type
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
        /// Get Output Type
        /// </summary>
        /// <param name="outputId">Id of the wanted output</param>
        public async Task<Models.OutputTypeResponse> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }
        
        internal interface ITypeApiClient
        {
            
            [Get("/encoding/outputs/{output_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.OutputTypeResponse> GetAsync([Path("output_id")] string outputId);
            
        }
        
    }
}
