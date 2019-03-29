using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.Channels.Versions.Latest
{
    public class LatestApi
    {
        private readonly ILatestApiClient _apiClient;

        public LatestApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILatestApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of LatestApi
        /// </summary>
        public static BitmovinApiBuilder<LatestApi> Builder => new BitmovinApiBuilder<LatestApi>();

        
        /// <summary>
        /// Get Latest Player Version for Channel
        /// </summary>
        /// <param name="channelName">Name of the channel to get the player versions for.</param>
        public async Task<Models.PlayerVersion> GetAsync(string channelName)
        {
            return await _apiClient.GetAsync(channelName);
        }
        
        internal interface ILatestApiClient
        {
            
            [Get("/player/channels/{channel_name}/versions/latest")]
            [AllowAnyStatusCode]
            Task<Models.PlayerVersion> GetAsync([Path("channel_name")] string channelName);
            
        }
        
    }
}
