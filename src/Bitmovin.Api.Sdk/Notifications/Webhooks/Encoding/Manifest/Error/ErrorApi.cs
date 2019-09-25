using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Manifest.Error
{
    public class ErrorApi
    {
        private readonly IErrorApiClient _apiClient;

        public ErrorApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IErrorApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of ErrorApi
        /// </summary>
        public static BitmovinApiBuilder<ErrorApi> Builder => new BitmovinApiBuilder<ErrorApi>();

        
        /// <summary>
        /// Add Manifest Error Webhook (All Manifests)
        /// </summary>
        /// <param name="webhook">The request payload</param>
        public async Task<Models.PaginationResponse<Models.Webhook>> CreateAsync(Models.Webhook webhook)
        {
            return await _apiClient.CreateAsync(webhook);
        }
        
        /// <summary>
        /// Add Manifest Error Webhook Notification (Specific Manifest)
        /// </summary>
        /// <param name="manifestId">Id of the manifest resource</param>
        /// <param name="webhook">The request payload</param>
        public async Task<Models.Webhook> CreateByManifestIdAsync(string manifestId, Models.Webhook webhook)
        {
            return await _apiClient.CreateByManifestIdAsync(manifestId, webhook);
        }
        
        /// <summary>
        /// Replace Manifest Error Webhook Notification
        /// </summary>
        /// <param name="notificationId">Id of the webhook notification</param>
        /// <param name="webhook">The request payload</param>
        public async Task<Models.Webhook> UpdateAsync(string notificationId, Models.Webhook webhook)
        {
            return await _apiClient.UpdateAsync(notificationId, webhook);
        }
        
        internal interface IErrorApiClient
        {
            
            [Post("/notifications/webhooks/encoding/manifest/error")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Webhook>> CreateAsync([Body] Models.Webhook webhook);
            
            [Post("/notifications/webhooks/encoding/manifest/{manifest_id}/error")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> CreateByManifestIdAsync([Path("manifest_id")] string manifestId, [Body] Models.Webhook webhook);
            
            [Put("/notifications/webhooks/encoding/manifest/error/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> UpdateAsync([Path("notification_id")] string notificationId, [Body] Models.Webhook webhook);
            
        }
        
    }
}
