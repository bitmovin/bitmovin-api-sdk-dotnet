using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Live.StandbyPools.Actions
{
    public class ActionsApi
    {
        private readonly IActionsApiClient _apiClient;

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
        public async Task<Models.LiveStandbyPoolEncoding> AcquireEncodingAsync(string poolId)
        {
            return await _apiClient.AcquireEncodingAsync(poolId);
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
            Task<Models.LiveStandbyPoolEncoding> AcquireEncodingAsync([Path("pool_id")] string poolId);

            [Post("/encoding/live/standby-pools/{pool_id}/actions/delete-error-encodings")]
            [AllowAnyStatusCode]
            Task<Models.LiveStandbyPoolEncoding> DeleteErrorEncodingsAsync([Path("pool_id")] string poolId);
        }
    }
}
