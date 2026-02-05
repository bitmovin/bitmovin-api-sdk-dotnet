using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.TransferError.Customdata
{
    /// <summary>
    /// API for CustomdataApi
    /// </summary>
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the CustomdataApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        /// <summary>
        /// &#39;Encoding Transfer Error&#39; Webhook Custom Data for a specific Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="webhookId">Id of the webhook (required)</param>
        public async Task<Models.CustomData> GetCustomDataByEncodingIdAndWebhookIdAsync(string encodingId, string webhookId)
        {
            return await _apiClient.GetCustomDataByEncodingIdAndWebhookIdAsync(encodingId, webhookId);
        }

        /// <summary>
        /// &#39;Encoding Transfer Error&#39; Webhook Custom Data
        /// </summary>
        /// <param name="webhookId">Id of the webhook (required)</param>
        public async Task<Models.CustomData> GetCustomDataByWebhookIdAsync(string webhookId)
        {
            return await _apiClient.GetCustomDataByWebhookIdAsync(webhookId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/notifications/webhooks/encoding/encodings/{encoding_id}/transfer-error/{webhook_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataByEncodingIdAndWebhookIdAsync([Path("encoding_id")] string encodingId, [Path("webhook_id")] string webhookId);

            [Get("/notifications/webhooks/encoding/encodings/transfer-error/{webhook_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataByWebhookIdAsync([Path("webhook_id")] string webhookId);
        }
    }
}
