using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Kubernetes.PrewarmedDeployment
{
    public class PrewarmedDeploymentApi
    {
        private readonly IPrewarmedDeploymentApiClient _apiClient;

        public PrewarmedDeploymentApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPrewarmedDeploymentApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of PrewarmedDeploymentApi
        /// </summary>
        public static BitmovinApiBuilder<PrewarmedDeploymentApi> Builder => new BitmovinApiBuilder<PrewarmedDeploymentApi>();

        /// <summary>
        /// Prewarm Encoders
        /// </summary>
        /// <param name="infrastructureId">Id of the kubernetes cluster. (required)</param>
        /// <param name="prewarmEncoderSettings">Settings for prewarming Encoders</param>
        public async Task<Models.PrewarmEncoderSettings> CreateAsync(string infrastructureId, Models.PrewarmEncoderSettings prewarmEncoderSettings)
        {
            return await _apiClient.CreateAsync(infrastructureId, prewarmEncoderSettings);
        }

        /// <summary>
        /// Delete Prewarmed Encoders
        /// </summary>
        /// <param name="infrastructureId">Id of the kubernetes cluster. (required)</param>
        /// <param name="deploymentId">Id of the prewarmed deployment. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string infrastructureId, string deploymentId)
        {
            return await _apiClient.DeleteAsync(infrastructureId, deploymentId);
        }

        /// <summary>
        /// Get Prewarmed Encoders
        /// </summary>
        /// <param name="infrastructureId">Id of the kubernetes cluster. (required)</param>
        /// <param name="deploymentId">Id of the prewarmed deployment. (required)</param>
        public async Task<Models.PrewarmEncoderSettings> GetAsync(string infrastructureId, string deploymentId)
        {
            return await _apiClient.GetAsync(infrastructureId, deploymentId);
        }

        /// <summary>
        /// List Prewarmed Encoders
        /// </summary>
        /// <param name="infrastructureId">Id of the kubernetes cluster. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PrewarmEncoderSettings>> ListAsync(string infrastructureId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(infrastructureId, q);
        }

        internal interface IPrewarmedDeploymentApiClient
        {
            [Post("/encoding/infrastructure/kubernetes/{infrastructure_id}/prewarmed-deployment")]
            [AllowAnyStatusCode]
            Task<Models.PrewarmEncoderSettings> CreateAsync([Path("infrastructure_id")] string infrastructureId, [Body] Models.PrewarmEncoderSettings prewarmEncoderSettings);

            [Delete("/encoding/infrastructure/kubernetes/{infrastructure_id}/prewarmed-deployment/{deployment_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("infrastructure_id")] string infrastructureId, [Path("deployment_id")] string deploymentId);

            [Get("/encoding/infrastructure/kubernetes/{infrastructure_id}/prewarmed-deployment/{deployment_id}")]
            [AllowAnyStatusCode]
            Task<Models.PrewarmEncoderSettings> GetAsync([Path("infrastructure_id")] string infrastructureId, [Path("deployment_id")] string deploymentId);

            [Get("/encoding/infrastructure/kubernetes/{infrastructure_id}/prewarmed-deployment")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PrewarmEncoderSettings>> ListAsync([Path("infrastructure_id")] string infrastructureId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
