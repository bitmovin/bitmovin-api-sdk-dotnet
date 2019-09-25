using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Manifest.Finished
{
    public class FinishedApi
    {
        private readonly IFinishedApiClient _apiClient;

        public FinishedApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFinishedApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of FinishedApi
        /// </summary>
        public static BitmovinApiBuilder<FinishedApi> Builder => new BitmovinApiBuilder<FinishedApi>();

        
        /// <summary>
        /// Add Manifest Finished Successfully Webhook (All Manifests)
        /// </summary>
        /// <param name="webhook">The request payload</param>
        public async Task<Models.PaginationResponse<Models.Webhook>> CreateAsync(Models.Webhook webhook)
        {
            return await _apiClient.CreateAsync(webhook);
        }
        
        /// <summary>
        /// Add Manifest Finished Successfully Webhook Notification (Specific Manifest)
        /// </summary>
        /// <param name="manifestId">Id of the manifest resource</param>
        /// <param name="webhook">The request payload</param>
        public async Task<Models.Webhook> CreateByManifestIdAsync(string manifestId, Models.Webhook webhook)
        {
            return await _apiClient.CreateByManifestIdAsync(manifestId, webhook);
        }
        
        /// <summary>
        /// Replace Manifest Finished Webhook Notification
        /// </summary>
        /// <param name="notificationId">Id of the webhook notification</param>
        /// <param name="webhook">The request payload</param>
        public async Task<Models.Webhook> UpdateAsync(string notificationId, Models.Webhook webhook)
        {
            return await _apiClient.UpdateAsync(notificationId, webhook);
        }
        
        internal interface IFinishedApiClient
        {
            
            [Post("/notifications/webhooks/encoding/manifest/finished")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Webhook>> CreateAsync([Body] Models.Webhook webhook);
            
            [Post("/notifications/webhooks/encoding/manifest/{manifest_id}/finished")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> CreateByManifestIdAsync([Path("manifest_id")] string manifestId, [Body] Models.Webhook webhook);
            
            [Put("/notifications/webhooks/encoding/manifest/finished/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> UpdateAsync([Path("notification_id")] string notificationId, [Body] Models.Webhook webhook);
            
        }
        
    }
}
