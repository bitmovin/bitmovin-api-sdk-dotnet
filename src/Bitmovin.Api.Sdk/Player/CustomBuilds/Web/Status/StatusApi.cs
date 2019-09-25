using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.CustomBuilds.Web.Status
{
    public class StatusApi
    {
        private readonly IStatusApiClient _apiClient;

        public StatusApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStatusApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of StatusApi
        /// </summary>
        public static BitmovinApiBuilder<StatusApi> Builder => new BitmovinApiBuilder<StatusApi>();

        
        /// <summary>
        /// Custom Web Player Build Status
        /// </summary>
        /// <param name="customBuildId">Id of the custom player build</param>
        public async Task<Models.CustomPlayerBuildStatus> GetAsync(string customBuildId)
        {
            return await _apiClient.GetAsync(customBuildId);
        }
        
        internal interface IStatusApiClient
        {
            
            [Get("/player/custom-builds/web/{custom_build_id}/status")]
            [AllowAnyStatusCode]
            Task<Models.CustomPlayerBuildStatus> GetAsync([Path("custom_build_id")] string customBuildId);
            
        }
        
    }
}
