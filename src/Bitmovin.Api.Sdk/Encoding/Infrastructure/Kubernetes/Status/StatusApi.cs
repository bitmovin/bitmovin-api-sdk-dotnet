using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.Status
{
    public class StatusApi
    {
        private readonly IStatusApiClient _apiClient;

        public StatusApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStatusApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of StatusApi
        /// </summary>
        public static BitmovinApiBuilder<StatusApi> Builder => new BitmovinApiBuilder<StatusApi>();

        
        /// <summary>
        /// Kubernetes Cluster Status
        /// </summary>
        /// <param name="infrastructureId">Id of the Kubernetes cluster</param>
        public async Task GetAsync(string infrastructureId)
        {
            await _apiClient.GetAsync(infrastructureId);
        }
        
        internal interface IStatusApiClient
        {
            
            [Get("/encoding/infrastructure/kubernetes/{infrastructure_id}/status")]
            [AllowAnyStatusCode]
            Task GetAsync([Path("infrastructure_id")] string infrastructureId);
            
        }
        
    }
}
