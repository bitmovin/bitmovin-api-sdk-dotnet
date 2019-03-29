using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.Channels.Versions.Latest;

namespace Bitmovin.Api.Sdk.Player.Channels.Versions
{
    public class VersionsApi
    {
        private readonly IVersionsApiClient _apiClient;

        public VersionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVersionsApiClient>();

            Latest = new LatestApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of VersionsApi
        /// </summary>
        public static BitmovinApiBuilder<VersionsApi> Builder => new BitmovinApiBuilder<VersionsApi>();

        public LatestApi Latest { get; private set; }
        
        /// <summary>
        /// List Player Versions for Channel
        /// </summary>
        /// <param name="channelName">Name of the channel to get the player versions for.</param>
        public async Task<Models.PaginationResponse<Models.PlayerVersion>> ListAsync(string channelName)
        {
            return await _apiClient.ListAsync(channelName);
        }
        
        internal interface IVersionsApiClient
        {
            
            [Get("/player/channels/{channel_name}/versions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PlayerVersion>> ListAsync([Path("channel_name")] string channelName);
            
        }
        
    }
}
