using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Live.StandbyPools.Actions;
using Bitmovin.Api.Sdk.Encoding.Live.StandbyPools.Encodings;
using Bitmovin.Api.Sdk.Encoding.Live.StandbyPools.Logs;

namespace Bitmovin.Api.Sdk.Encoding.Live.StandbyPools
{
    public class StandbyPoolsApi
    {
        private readonly IStandbyPoolsApiClient _apiClient;

        public StandbyPoolsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStandbyPoolsApiClient>();
            Actions = new ActionsApi(apiClientFactory);
            Encodings = new EncodingsApi(apiClientFactory);
            Logs = new LogsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of StandbyPoolsApi
        /// </summary>
        public static BitmovinApiBuilder<StandbyPoolsApi> Builder => new BitmovinApiBuilder<StandbyPoolsApi>();

        public ActionsApi Actions { get; }
        public EncodingsApi Encodings { get; }
        public LogsApi Logs { get; }

        /// <summary>
        /// Create new standby pool
        /// </summary>
        /// <param name="liveStandbyPoolRequest">The pool to be created</param>
        public async Task<Models.LiveStandbyPoolDetails> CreateAsync(Models.LiveStandbyPoolRequest liveStandbyPoolRequest)
        {
            return await _apiClient.CreateAsync(liveStandbyPoolRequest);
        }

        /// <summary>
        /// Delete standby pool by id
        /// </summary>
        /// <param name="poolId">Id of the standby pool (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string poolId)
        {
            return await _apiClient.DeleteAsync(poolId);
        }

        /// <summary>
        /// Get details of a standby pool by id
        /// </summary>
        /// <param name="poolId">Id of the standby pool (required)</param>
        public async Task<Models.LiveStandbyPoolDetails> GetAsync(string poolId)
        {
            return await _apiClient.GetAsync(poolId);
        }

        /// <summary>
        /// List Standby pools
        /// </summary>
        public async Task<Models.PaginationResponse<Models.LiveStandbyPoolResponse>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }

        /// <summary>
        /// Partially update standby pool by id
        /// </summary>
        /// <param name="poolId">Id of the standby pool (required)</param>
        /// <param name="liveStandbyPoolUpdate">The updated standby pool object.</param>
        public async Task<Models.LiveStandbyPoolDetails> PatchAsync(string poolId, Models.LiveStandbyPoolUpdate liveStandbyPoolUpdate)
        {
            return await _apiClient.PatchAsync(poolId, liveStandbyPoolUpdate);
        }

        internal interface IStandbyPoolsApiClient
        {
            [Post("/encoding/live/standby-pools")]
            [AllowAnyStatusCode]
            Task<Models.LiveStandbyPoolDetails> CreateAsync([Body] Models.LiveStandbyPoolRequest liveStandbyPoolRequest);

            [Delete("/encoding/live/standby-pools/{pool_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("pool_id")] string poolId);

            [Get("/encoding/live/standby-pools/{pool_id}")]
            [AllowAnyStatusCode]
            Task<Models.LiveStandbyPoolDetails> GetAsync([Path("pool_id")] string poolId);

            [Get("/encoding/live/standby-pools")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.LiveStandbyPoolResponse>> ListAsync();

            [Patch("/encoding/live/standby-pools/{pool_id}")]
            [AllowAnyStatusCode]
            Task<Models.LiveStandbyPoolDetails> PatchAsync([Path("pool_id")] string poolId, [Body] Models.LiveStandbyPoolUpdate liveStandbyPoolUpdate);
        }
    }
}
