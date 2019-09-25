using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.AgentDeployment
{
    public class AgentDeploymentApi
    {
        private readonly IAgentDeploymentApiClient _apiClient;

        public AgentDeploymentApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAgentDeploymentApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of AgentDeploymentApi
        /// </summary>
        public static BitmovinApiBuilder<AgentDeploymentApi> Builder => new BitmovinApiBuilder<AgentDeploymentApi>();

        
        /// <summary>
        /// Download bitmovin-agent deployment
        /// </summary>
        /// <param name="infrastructureId">Id of the Kubernetes cluster</param>
        public async Task GetAsync(string infrastructureId)
        {
            await _apiClient.GetAsync(infrastructureId);
        }
        
        internal interface IAgentDeploymentApiClient
        {
            
            [Get("/encoding/infrastructure/kubernetes/{infrastructure_id}/agent-deployment")]
            [AllowAnyStatusCode]
            Task GetAsync([Path("infrastructure_id")] string infrastructureId);
            
        }
        
    }
}
