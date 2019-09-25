using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.Finished.Customdata
{
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        
        /// <summary>
        /// Encoding Finished Webhook Custom Data for specific Encoding Resource
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="webhookId">Id of the webhook</param>
        public async Task<Models.CustomData> GetCustomDataByEncodingIdAndWebhookIdAsync(string encodingId, string webhookId)
        {
            return await _apiClient.GetCustomDataByEncodingIdAndWebhookIdAsync(encodingId, webhookId);
        }
        
        /// <summary>
        /// Encoding Finished Webhook Custom Data
        /// </summary>
        /// <param name="webhookId">Id of the webhook</param>
        public async Task<Models.CustomData> GetCustomDataByWebhookIdAsync(string webhookId)
        {
            return await _apiClient.GetCustomDataByWebhookIdAsync(webhookId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/notifications/webhooks/encoding/encodings/{encoding_id}/finished/{webhook_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataByEncodingIdAndWebhookIdAsync([Path("encoding_id")] string encodingId, [Path("webhook_id")] string webhookId);
            
            [Get("/notifications/webhooks/encoding/encodings/finished/{webhook_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataByWebhookIdAsync([Path("webhook_id")] string webhookId);
            
        }
        
    }
}
