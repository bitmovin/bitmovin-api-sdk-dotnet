using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.Configuration
{
    public class ConfigurationApi
    {
        private readonly IConfigurationApiClient _apiClient;

        public ConfigurationApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IConfigurationApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of ConfigurationApi
        /// </summary>
        public static BitmovinApiBuilder<ConfigurationApi> Builder => new BitmovinApiBuilder<ConfigurationApi>();

        
        /// <summary>
        /// Retrieve Kubernetes Cluster Configuration
        /// </summary>
        /// <param name="infrastructureId">Id of the Kubernetes cluster</param>
        public async Task<Models.KubernetesClusterConfiguration> GetAsync(string infrastructureId)
        {
            return await _apiClient.GetAsync(infrastructureId);
        }
        
        /// <summary>
        /// Update Kubernetes Cluster Configuration
        /// </summary>
        /// <param name="infrastructureId">Id of the Kubernetes cluster</param>
        /// <param name="kubernetesClusterConfiguration">The request payload</param>
        public async Task<Models.KubernetesClusterConfiguration> UpdateAsync(string infrastructureId, Models.KubernetesClusterConfiguration kubernetesClusterConfiguration)
        {
            return await _apiClient.UpdateAsync(infrastructureId, kubernetesClusterConfiguration);
        }
        
        internal interface IConfigurationApiClient
        {
            
            [Get("/encoding/infrastructure/kubernetes/{infrastructure_id}/configuration")]
            [AllowAnyStatusCode]
            Task<Models.KubernetesClusterConfiguration> GetAsync([Path("infrastructure_id")] string infrastructureId);
            
            [Put("/encoding/infrastructure/kubernetes/{infrastructure_id}/configuration")]
            [AllowAnyStatusCode]
            Task<Models.KubernetesClusterConfiguration> UpdateAsync([Path("infrastructure_id")] string infrastructureId, [Body] Models.KubernetesClusterConfiguration kubernetesClusterConfiguration);
            
        }
        
    }
}
