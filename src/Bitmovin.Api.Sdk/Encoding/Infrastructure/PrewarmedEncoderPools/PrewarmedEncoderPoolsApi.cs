using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.PrewarmedEncoderPools.Schedules;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.PrewarmedEncoderPools
{
    /// <summary>
    /// API for PrewarmedEncoderPoolsApi
    /// </summary>
    public class PrewarmedEncoderPoolsApi
    {
        private readonly IPrewarmedEncoderPoolsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the PrewarmedEncoderPoolsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public PrewarmedEncoderPoolsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPrewarmedEncoderPoolsApiClient>();
            Schedules = new SchedulesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of PrewarmedEncoderPoolsApi
        /// </summary>
        public static BitmovinApiBuilder<PrewarmedEncoderPoolsApi> Builder => new BitmovinApiBuilder<PrewarmedEncoderPoolsApi>();

        /// <summary>
        /// Gets the Schedules API
        /// </summary>
        public SchedulesApi Schedules { get; }

        /// <summary>
        /// Create prewarmed encoder pool
        /// </summary>
        /// <param name="prewarmedEncoderPool">The prewarmed encoder pool to be created</param>
        public async Task<Models.PrewarmedEncoderPool> CreateAsync(Models.PrewarmedEncoderPool prewarmedEncoderPool)
        {
            return await _apiClient.CreateAsync(prewarmedEncoderPool);
        }

        /// <summary>
        /// Delete prewarmed encoder pool
        /// </summary>
        /// <param name="poolId">Id of the prewarmed encoder pool (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string poolId)
        {
            return await _apiClient.DeleteAsync(poolId);
        }

        /// <summary>
        /// Prewarmed encoder pool details
        /// </summary>
        /// <param name="poolId">Id of the prewarmed encoder pool (required)</param>
        public async Task<Models.PrewarmedEncoderPool> GetAsync(string poolId)
        {
            return await _apiClient.GetAsync(poolId);
        }

        /// <summary>
        /// List prewarmed encoder pools
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PrewarmedEncoderPool>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Start prewarmed encoder pool
        /// </summary>
        /// <param name="poolId">Id of the prewarmed encoder pool to be started (required)</param>
        public async Task<Models.BitmovinResponse> StartAsync(string poolId)
        {
            return await _apiClient.StartAsync(poolId);
        }

        /// <summary>
        /// Stop prewarmed encoder pool
        /// </summary>
        /// <param name="poolId">Id of the prewarmed encoder pool to be stopped (required)</param>
        public async Task<Models.BitmovinResponse> StopAsync(string poolId)
        {
            return await _apiClient.StopAsync(poolId);
        }

        internal interface IPrewarmedEncoderPoolsApiClient
        {
            [Post("/encoding/infrastructure/prewarmed-encoder-pools")]
            [AllowAnyStatusCode]
            Task<Models.PrewarmedEncoderPool> CreateAsync([Body] Models.PrewarmedEncoderPool prewarmedEncoderPool);

            [Delete("/encoding/infrastructure/prewarmed-encoder-pools/{pool_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("pool_id")] string poolId);

            [Get("/encoding/infrastructure/prewarmed-encoder-pools/{pool_id}")]
            [AllowAnyStatusCode]
            Task<Models.PrewarmedEncoderPool> GetAsync([Path("pool_id")] string poolId);

            [Get("/encoding/infrastructure/prewarmed-encoder-pools")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PrewarmedEncoderPool>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/encoding/infrastructure/prewarmed-encoder-pools/{pool_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("pool_id")] string poolId);

            [Post("/encoding/infrastructure/prewarmed-encoder-pools/{pool_id}/stop")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StopAsync([Path("pool_id")] string poolId);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
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
