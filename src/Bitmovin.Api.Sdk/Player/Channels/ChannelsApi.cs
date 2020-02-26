using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.Channels.Versions;

namespace Bitmovin.Api.Sdk.Player.Channels
{
    public class ChannelsApi
    {
        private readonly IChannelsApiClient _apiClient;

        public ChannelsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IChannelsApiClient>();
            Versions = new VersionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ChannelsApi
        /// </summary>
        public static BitmovinApiBuilder<ChannelsApi> Builder => new BitmovinApiBuilder<ChannelsApi>();

        public VersionsApi Versions { get; }

        /// <summary>
        /// List Player Channels
        /// </summary>
        public async Task<Models.PaginationResponse<Models.PlayerChannel>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }

        internal interface IChannelsApiClient
        {
            [Get("/player/channels")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PlayerChannel>> ListAsync();
        }
    }
}
