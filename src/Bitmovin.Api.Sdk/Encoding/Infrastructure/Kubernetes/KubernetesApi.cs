using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.Status;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.Customdata;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.Configuration;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.AgentDeployment;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.PrewarmedDeployment;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes
{
    public class KubernetesApi
    {
        private readonly IKubernetesApiClient _apiClient;

        public KubernetesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IKubernetesApiClient>();
            Status = new StatusApi(apiClientFactory);
            Customdata = new CustomdataApi(apiClientFactory);
            Configuration = new ConfigurationApi(apiClientFactory);
            AgentDeployment = new AgentDeploymentApi(apiClientFactory);
            PrewarmedDeployment = new PrewarmedDeploymentApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of KubernetesApi
        /// </summary>
        public static BitmovinApiBuilder<KubernetesApi> Builder => new BitmovinApiBuilder<KubernetesApi>();

        public StatusApi Status { get; }
        public CustomdataApi Customdata { get; }
        public ConfigurationApi Configuration { get; }
        public AgentDeploymentApi AgentDeployment { get; }
        public PrewarmedDeploymentApi PrewarmedDeployment { get; }

        /// <summary>
        /// Connect Kubernetes Cluster
        /// </summary>
        /// <param name="kubernetesCluster">The Kubernetes Cluster to be created</param>
        public async Task<Models.KubernetesCluster> CreateAsync(Models.KubernetesCluster kubernetesCluster)
        {
            return await _apiClient.CreateAsync(kubernetesCluster);
        }

        /// <summary>
        /// Disconnect Kubernetes Cluster
        /// </summary>
        /// <param name="infrastructureId">Id of the Kubernetes cluster (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string infrastructureId)
        {
            return await _apiClient.DeleteAsync(infrastructureId);
        }

        /// <summary>
        /// Kubernetes Cluster Details
        /// </summary>
        /// <param name="infrastructureId">Id of the Kubernetes cluster (required)</param>
        public async Task<Models.KubernetesCluster> GetAsync(string infrastructureId)
        {
            return await _apiClient.GetAsync(infrastructureId);
        }

        /// <summary>
        /// List Kubernetes Cluster
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.KubernetesCluster>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IKubernetesApiClient
        {
            [Post("/encoding/infrastructure/kubernetes")]
            [AllowAnyStatusCode]
            Task<Models.KubernetesCluster> CreateAsync([Body] Models.KubernetesCluster kubernetesCluster);

            [Delete("/encoding/infrastructure/kubernetes/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/kubernetes/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.KubernetesCluster> GetAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/kubernetes")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.KubernetesCluster>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

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
