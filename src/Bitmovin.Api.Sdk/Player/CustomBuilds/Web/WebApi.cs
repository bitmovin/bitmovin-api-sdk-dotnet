using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.CustomBuilds.Web.Domains;
using Bitmovin.Api.Sdk.Player.CustomBuilds.Web.Status;
using Bitmovin.Api.Sdk.Player.CustomBuilds.Web.Download;

namespace Bitmovin.Api.Sdk.Player.CustomBuilds.Web
{
    public class WebApi
    {
        private readonly IWebApiClient _apiClient;

        public WebApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWebApiClient>();

            Domains = new DomainsApi(apiClientFactory);
            Status = new StatusApi(apiClientFactory);
            Download = new DownloadApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WebApi
        /// </summary>
        public static BitmovinApiBuilder<WebApi> Builder => new BitmovinApiBuilder<WebApi>();

        public DomainsApi Domains { get; private set; }
        public StatusApi Status { get; private set; }
        public DownloadApi Download { get; private set; }
        
        /// <summary>
        /// Add Custom Web Player Build
        /// </summary>
        /// <param name="customPlayerBuildDetails">The request payload</param>
        public async Task<Models.CustomPlayerBuildDetails> CreateAsync(Models.CustomPlayerBuildDetails customPlayerBuildDetails)
        {
            return await _apiClient.CreateAsync(customPlayerBuildDetails);
        }
        
        /// <summary>
        /// Custom Web Player Build Details
        /// </summary>
        /// <param name="customBuildId">Id of the custom player build</param>
        public async Task<Models.CustomPlayerBuildStatus> GetAsync(string customBuildId)
        {
            return await _apiClient.GetAsync(customBuildId);
        }
        
        /// <summary>
        /// List Custom Web Player Builds
        /// </summary>
        public async Task<Models.PaginationResponse<Models.CustomPlayerBuildDetails>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }
        
        /// <summary>
        /// Start Custom Web Player Build
        /// </summary>
        /// <param name="customBuildId">Id of the custom player build</param>
        public async Task<Models.BitmovinResponse> StartAsync(string customBuildId)
        {
            return await _apiClient.StartAsync(customBuildId);
        }
        
        internal interface IWebApiClient
        {
            
            [Post("/player/custom-builds/web")]
            [AllowAnyStatusCode]
            Task<Models.CustomPlayerBuildDetails> CreateAsync([Body] Models.CustomPlayerBuildDetails customPlayerBuildDetails);
            
            [Get("/player/custom-builds/web/{custom_build_id}")]
            [AllowAnyStatusCode]
            Task<Models.CustomPlayerBuildStatus> GetAsync([Path("custom_build_id")] string customBuildId);
            
            [Get("/player/custom-builds/web")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CustomPlayerBuildDetails>> ListAsync();
            
            [Post("/player/custom-builds/web/{custom_build_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("custom_build_id")] string customBuildId);
            
        }
        
    }
}
