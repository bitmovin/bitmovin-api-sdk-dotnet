using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Live.StreamKeys.Actions
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
        /// Unassign stream keys
        /// </summary>
        /// <param name="streamKeysUnassignAction">The action payload for unassigning stream keys</param>
        public async Task<Models.StreamKeysUnassignAction> UnassignAsync(Models.StreamKeysUnassignAction streamKeysUnassignAction)
        {
            return await _apiClient.UnassignAsync(streamKeysUnassignAction);
        }

        internal interface IActionsApiClient
        {
            [Post("/encoding/live/stream-keys/actions/unassign")]
            [AllowAnyStatusCode]
            Task<Models.StreamKeysUnassignAction> UnassignAsync([Body] Models.StreamKeysUnassignAction streamKeysUnassignAction);
        }
    }
}
