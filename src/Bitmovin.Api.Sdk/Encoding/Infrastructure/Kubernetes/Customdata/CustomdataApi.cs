using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.Customdata
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
        /// Kubernetes Cluster Custom Data
        /// </summary>
        /// <param name="infrastructureId">Id of the Kubernetes cluster</param>
        public async Task<Models.CustomData> GetAsync(string infrastructureId)
        {
            return await _apiClient.GetAsync(infrastructureId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/infrastructure/kubernetes/{infrastructure_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("infrastructure_id")] string infrastructureId);
            
        }
        
    }
}
