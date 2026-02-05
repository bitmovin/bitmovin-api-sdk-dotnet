using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Live.StandbyPools.Actions
{
    /// <summary>
    /// API for ActionsApi
    /// </summary>
    public class ActionsApi
    {
        private readonly IActionsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ActionsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ActionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IActionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ActionsApi
        /// </summary>
        public static BitmovinApiBuilder<ActionsApi> Builder => new BitmovinApiBuilder<ActionsApi>();

        /// <summary>
        /// Acquire an encoding from a standby pool
        /// </summary>
        /// <param name="poolId">Id of the standby pool (required)</param>
        /// <param name="liveStandbyPoolAcquireEncoding">The optionally provided payload for acquiring an encoding</param>
        public async Task<Models.LiveStandbyPoolEncoding> AcquireEncodingAsync(string poolId, Models.LiveStandbyPoolAcquireEncoding liveStandbyPoolAcquireEncoding = null)
        {
            return await _apiClient.AcquireEncodingAsync(poolId, liveStandbyPoolAcquireEncoding);
        }

        /// <summary>
        /// Delete error encodings from the standby pool
        /// </summary>
        /// <param name="poolId">Id of the standby pool (required)</param>
        public async Task<Models.LiveStandbyPoolEncoding> DeleteErrorEncodingsAsync(string poolId)
        {
            return await _apiClient.DeleteErrorEncodingsAsync(poolId);
        }

        internal interface IActionsApiClient
        {
            [Post("/encoding/live/standby-pools/{pool_id}/actions/acquire-encoding")]
            [AllowAnyStatusCode]
            Task<Models.LiveStandbyPoolEncoding> AcquireEncodingAsync([Path("pool_id")] string poolId, [Body] Models.LiveStandbyPoolAcquireEncoding liveStandbyPoolAcquireEncoding);

            [Post("/encoding/live/standby-pools/{pool_id}/actions/delete-error-encodings")]
            [AllowAnyStatusCode]
            Task<Models.LiveStandbyPoolEncoding> DeleteErrorEncodingsAsync([Path("pool_id")] string poolId);
        }
    }
}
