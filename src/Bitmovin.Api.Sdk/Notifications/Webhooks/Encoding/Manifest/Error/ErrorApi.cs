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
        /// Add &#39;Manifest Error&#39; Webhook (All Manifests)
        /// </summary>
        /// <param name="webhook">The &#39;Manifest Error&#39; Webhook to be added.</param>
        public async Task<Models.Webhook> CreateAsync(Models.Webhook webhook)
        {
            return await _apiClient.CreateAsync(webhook);
        }

        /// <summary>
        /// Add &#39;Manifest Error&#39; Webhook Notification (Specific Manifest)
        /// </summary>
        /// <param name="manifestId">Id of the manifest resource (required)</param>
        /// <param name="webhook">The webhook notifications object. A maximum number of 5 webhooks per Manifest is allowed</param>
        public async Task<Models.Webhook> CreateByManifestIdAsync(string manifestId, Models.Webhook webhook)
        {
            return await _apiClient.CreateByManifestIdAsync(manifestId, webhook);
        }

        /// <summary>
        /// Delete &#39;Manifest Error&#39; Webhook
        /// </summary>
        /// <param name="notificationId">Id of the webhook notification (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string notificationId)
        {
            return await _apiClient.DeleteAsync(notificationId);
        }

        /// <summary>
        /// Get &#39;Manifest Error&#39; Webhooks (All Manifests)
        /// </summary>
        public async Task<Models.PaginationResponse<Models.Webhook>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }

        /// <summary>
        /// Replace &#39;Manifest Error&#39; Webhook Notification
        /// </summary>
        /// <param name="notificationId">Id of the webhook notification (required)</param>
        /// <param name="webhook">The webhook notification with the updated values</param>
        public async Task<Models.Webhook> UpdateAsync(string notificationId, Models.Webhook webhook)
        {
            return await _apiClient.UpdateAsync(notificationId, webhook);
        }

        internal interface IErrorApiClient
        {
            [Post("/notifications/webhooks/encoding/manifest/error")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> CreateAsync([Body] Models.Webhook webhook);

            [Post("/notifications/webhooks/encoding/manifest/{manifest_id}/error")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> CreateByManifestIdAsync([Path("manifest_id")] string manifestId, [Body] Models.Webhook webhook);

            [Delete("/notifications/webhooks/encoding/manifest/error/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("notification_id")] string notificationId);

            [Get("/notifications/webhooks/encoding/manifest/error")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Webhook>> ListAsync();

            [Put("/notifications/webhooks/encoding/manifest/error/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> UpdateAsync([Path("notification_id")] string notificationId, [Body] Models.Webhook webhook);
        }
    }
}
