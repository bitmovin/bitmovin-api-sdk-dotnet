using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.LiveEncodingHeartbeat
{
    public class LiveEncodingHeartbeatApi
    {
        private readonly ILiveEncodingHeartbeatApiClient _apiClient;

        public LiveEncodingHeartbeatApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveEncodingHeartbeatApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveEncodingHeartbeatApi
        /// </summary>
        public static BitmovinApiBuilder<LiveEncodingHeartbeatApi> Builder => new BitmovinApiBuilder<LiveEncodingHeartbeatApi>();

        /// <summary>
        /// Add &#39;Live Encoding Heartbeat&#39; Webhook
        /// </summary>
        /// <param name="liveEncodingHeartbeatWebhook">The &#39;Live Encoding Heartbeat&#39; Webhook to be added.</param>
        public async Task<Models.LiveEncodingHeartbeatWebhook> CreateAsync(Models.LiveEncodingHeartbeatWebhook liveEncodingHeartbeatWebhook)
        {
            return await _apiClient.CreateAsync(liveEncodingHeartbeatWebhook);
        }

        /// <summary>
        /// Delete &#39;Live Encoding Heartbeat&#39; Webhook
        /// </summary>
        /// <param name="webhookId">Id of the webhook (required)</param>
        public async Task<Models.BitmovinResponse> DeleteByWebhookIdAsync(string webhookId)
        {
            return await _apiClient.DeleteByWebhookIdAsync(webhookId);
        }

        /// <summary>
        /// &#39;Live Encoding Heartbeat&#39; Webhook Details
        /// </summary>
        /// <param name="webhookId">Id of the webhook (required)</param>
        public async Task<Models.LiveEncodingHeartbeatWebhook> GetByWebhookIdAsync(string webhookId)
        {
            return await _apiClient.GetByWebhookIdAsync(webhookId);
        }

        /// <summary>
        /// List &#39;Live Encoding Heartbeat&#39; Webhooks
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.LiveEncodingHeartbeatWebhook>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface ILiveEncodingHeartbeatApiClient
        {
            [Post("/notifications/webhooks/encoding/encodings/live-encoding-heartbeat")]
            [AllowAnyStatusCode]
            Task<Models.LiveEncodingHeartbeatWebhook> CreateAsync([Body] Models.LiveEncodingHeartbeatWebhook liveEncodingHeartbeatWebhook);

            [Delete("/notifications/webhooks/encoding/encodings/live-encoding-heartbeat/{webhook_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteByWebhookIdAsync([Path("webhook_id")] string webhookId);

            [Get("/notifications/webhooks/encoding/encodings/live-encoding-heartbeat/{webhook_id}")]
            [AllowAnyStatusCode]
            Task<Models.LiveEncodingHeartbeatWebhook> GetByWebhookIdAsync([Path("webhook_id")] string webhookId);

            [Get("/notifications/webhooks/encoding/encodings/live-encoding-heartbeat")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.LiveEncodingHeartbeatWebhook>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}
