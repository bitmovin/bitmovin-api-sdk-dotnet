using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.LiveInputStreamChanged
{
    /// <summary>
    /// API for LiveInputStreamChangedApi
    /// </summary>
    public class LiveInputStreamChangedApi
    {
        private readonly ILiveInputStreamChangedApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the LiveInputStreamChangedApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public LiveInputStreamChangedApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveInputStreamChangedApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveInputStreamChangedApi
        /// </summary>
        public static BitmovinApiBuilder<LiveInputStreamChangedApi> Builder => new BitmovinApiBuilder<LiveInputStreamChangedApi>();

        /// <summary>
        /// Add Live Input Stream Changed Webhook Notification (All Encodings)
        /// </summary>
        /// <param name="webhookNotificationWithStreamConditionsRequest">The webhook notifications object</param>
        public async Task<Models.WebhookNotificationWithStreamConditions> CreateAsync(Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest)
        {
            return await _apiClient.CreateAsync(webhookNotificationWithStreamConditionsRequest);
        }

        /// <summary>
        /// Add Live Input Stream Changed Webhook Notification (Specific Encoding)
        /// </summary>
        /// <param name="encodingId">Id of the encoding resource (required)</param>
        /// <param name="webhookNotificationWithStreamConditionsRequest">The webhook notifications object</param>
        public async Task<Models.WebhookNotificationWithStreamConditions> CreateByEncodingIdAsync(string encodingId, Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest)
        {
            return await _apiClient.CreateByEncodingIdAsync(encodingId, webhookNotificationWithStreamConditionsRequest);
        }

        /// <summary>
        /// Replace Live Input Stream Changed Webhook Notification
        /// </summary>
        /// <param name="notificationId">Id of the webhook notification (required)</param>
        /// <param name="webhookNotificationWithStreamConditionsRequest">The webhook notification with the updated values</param>
        public async Task<Models.WebhookNotificationWithStreamConditions> UpdateAsync(string notificationId, Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest)
        {
            return await _apiClient.UpdateAsync(notificationId, webhookNotificationWithStreamConditionsRequest);
        }

        internal interface ILiveInputStreamChangedApiClient
        {
            [Post("/notifications/webhooks/encoding/encodings/live-input-stream-changed")]
            [AllowAnyStatusCode]
            Task<Models.WebhookNotificationWithStreamConditions> CreateAsync([Body] Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest);

            [Post("/notifications/webhooks/encoding/encodings/{encoding_id}/live-input-stream-changed")]
            [AllowAnyStatusCode]
            Task<Models.WebhookNotificationWithStreamConditions> CreateByEncodingIdAsync([Path("encoding_id")] string encodingId, [Body] Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest);

            [Put("/notifications/webhooks/encoding/encodings/live-input-stream-changed/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebhookNotificationWithStreamConditions> UpdateAsync([Path("notification_id")] string notificationId, [Body] Models.WebhookNotificationWithStreamConditionsRequest webhookNotificationWithStreamConditionsRequest);
        }
    }
}
