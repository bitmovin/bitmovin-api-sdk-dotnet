using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.CustomBuilds.Web.Download
{
    /// <summary>
    /// API for DownloadApi
    /// </summary>
    public class DownloadApi
    {
        private readonly IDownloadApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DownloadApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DownloadApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDownloadApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DownloadApi
        /// </summary>
        public static BitmovinApiBuilder<DownloadApi> Builder => new BitmovinApiBuilder<DownloadApi>();

        /// <summary>
        /// Custom Web Player Build Download Link
        /// </summary>
        /// <param name="customBuildId">Id of the custom player build (required)</param>
        public async Task<Models.CustomPlayerBuildDownload> GetAsync(string customBuildId)
        {
            return await _apiClient.GetAsync(customBuildId);
        }

        internal interface IDownloadApiClient
        {
            [Get("/player/custom-builds/web/{custom_build_id}/download")]
            [AllowAnyStatusCode]
            Task<Models.CustomPlayerBuildDownload> GetAsync([Path("custom_build_id")] string customBuildId);
        }
    }
}
