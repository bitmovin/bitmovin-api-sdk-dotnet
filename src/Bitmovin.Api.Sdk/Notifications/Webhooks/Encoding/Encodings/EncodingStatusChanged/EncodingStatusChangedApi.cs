using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.EncodingStatusChanged
{
    /// <summary>
    /// API for EncodingStatusChangedApi
    /// </summary>
    public class EncodingStatusChangedApi
    {
        private readonly IEncodingStatusChangedApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the EncodingStatusChangedApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public EncodingStatusChangedApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEncodingStatusChangedApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingStatusChangedApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingStatusChangedApi> Builder => new BitmovinApiBuilder<EncodingStatusChangedApi>();

        /// <summary>
        /// Add Encoding Changed Webhook Notification (All Encodings)
        /// </summary>
        /// <param name="webhookNotificationWithStreamConditionsRequest">The webhook notifications object. For conditions, following attributes are possible: &#39;type&#39;: &#39;Input file download&#39;, &#39;Input file analysis&#39;, &#39;Per-Title analysis&#39;, &#39;Encoding&#39;, &#39;Progressive Muxing&#39; &#39;progress&#39;: number in range of 0-100 &#39;status&#39;: &#39;RUNNING&#39;, &#39;FINISHED&#39;, &#39;ERROR&#39; Examples: To only get notified about the encoding process, create a Condition object and set attribute&#x3D;&#39;type&#39;, value&#x3D;&#39;Encoding&#39;, operator&#x3D;EQUAL To only get notified if a workflow step is finished, create a Condition object and set attribute&#x3D;&#39;status&#39;, value&#x3D;&#39;FINISHED&#39;, operator&#x3D;EQUAL To only get notified if a workflow step is over 50%,  create a Condition object and set attribute&#x3D;&#39;progress&#39;, value&#x3D;&#39;50&#39;, operator&#x3D;GREATER_THAN</param>
        public async Task<Models.WebhookNotificationWithStreamConditions> CreateAsync(Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest)
        {
            return await _apiClient.CreateAsync(webhookNotificationWithStreamConditionsRequest);
        }

        /// <summary>
        /// Add Encoding Changed Webhook Notification (Specific Encoding)
        /// </summary>
        /// <param name="encodingId">Id of the encoding resource (required)</param>
        /// <param name="webhookNotificationWithStreamConditionsRequest">The webhook notifications object. For conditions, following attributes are possible: &#39;type&#39;: &#39;Input file download&#39;, &#39;Input file analysis&#39;, &#39;Per-Title analysis&#39;, &#39;Encoding&#39;, &#39;Progressive Muxing&#39; &#39;progress&#39;: number in range of 0-100 &#39;status&#39;: &#39;RUNNING&#39;, &#39;FINISHED&#39;, &#39;ERROR&#39; Examples: To only get notified about the encoding process, create a Condition object and set attribute&#x3D;&#39;type&#39;, value&#x3D;&#39;Encoding&#39;, operator&#x3D;EQUAL To only get notified if a workflow step is finished, create a Condition object and set attribute&#x3D;&#39;status&#39;, value&#x3D;&#39;FINISHED&#39;, operator&#x3D;EQUAL To only get notified if a workflow step is over 50%,  create a Condition object and set attribute&#x3D;&#39;progress&#39;, value&#x3D;&#39;50&#39;, operator&#x3D;GREATER_THAN </param>
        public async Task<Models.WebhookNotificationWithStreamConditions> CreateByEncodingIdAsync(string encodingId, Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest)
        {
            return await _apiClient.CreateByEncodingIdAsync(encodingId, webhookNotificationWithStreamConditionsRequest);
        }

        /// <summary>
        /// Delete Encoding Status Changed Webhook
        /// </summary>
        /// <param name="notificationId">Id of the webhook (required)</param>
        public async Task<Models.BitmovinResponse> DeleteByWebhookIdAsync(string notificationId)
        {
            return await _apiClient.DeleteByWebhookIdAsync(notificationId);
        }

        /// <summary>
        /// Replace Encoding Status Changed Webhook Notification
        /// </summary>
        /// <param name="notificationId">Id of the webhook notification (required)</param>
        /// <param name="webhookNotificationWithStreamConditionsRequest">The webhook notification with the updated values</param>
        public async Task<Models.WebhookNotificationWithStreamConditions> UpdateAsync(string notificationId, Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest)
        {
            return await _apiClient.UpdateAsync(notificationId, webhookNotificationWithStreamConditionsRequest);
        }

        internal interface IEncodingStatusChangedApiClient
        {
            [Post("/notifications/webhooks/encoding/encodings/encoding-status-changed")]
            [AllowAnyStatusCode]
            Task<Models.WebhookNotificationWithStreamConditions> CreateAsync([Body] Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest);

            [Post("/notifications/webhooks/encoding/encodings/{encoding_id}/encoding-status-changed")]
            [AllowAnyStatusCode]
            Task<Models.WebhookNotificationWithStreamConditions> CreateByEncodingIdAsync([Path("encoding_id")] string encodingId, [Body] Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest);

            [Delete("/notifications/webhooks/encoding/encodings/encoding-status-changed/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteByWebhookIdAsync([Path("notification_id")] string notificationId);

            [Put("/notifications/webhooks/encoding/encodings/encoding-status-changed/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebhookNotificationWithStreamConditions> UpdateAsync([Path("notification_id")] string notificationId, [Body] Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest);
        }
    }
}
