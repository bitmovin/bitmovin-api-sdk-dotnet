using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.TransferError.Customdata;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.TransferError
{
    public class TransferErrorApi
    {
        private readonly ITransferErrorApiClient _apiClient;

        public TransferErrorApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITransferErrorApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of TransferErrorApi
        /// </summary>
        public static BitmovinApiBuilder<TransferErrorApi> Builder => new BitmovinApiBuilder<TransferErrorApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add Encoding Transfer Error Webhook
        /// </summary>
        /// <param name="webhook">The Encoding Transfer Error Webhook to be added. **Note:** A maximum number of 5 webhooks is allowed</param>
        public async Task<Models.Webhook> CreateAsync(Models.Webhook webhook)
        {
            return await _apiClient.CreateAsync(webhook);
        }

        /// <summary>
        /// Add Encoding Transfer Error Webhook for specific Encoding Resource
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="webhook">The Encoding Transfer Error Webhook to be added. **Note:** A maximum number of 5 webhooks is allowed</param>
        public async Task<Models.Webhook> CreateByEncodingIdAsync(string encodingId, Models.Webhook webhook)
        {
            return await _apiClient.CreateByEncodingIdAsync(encodingId, webhook);
        }

        /// <summary>
        /// Delete Encoding Transfer Error Webhook for specific Encoding Resource
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="webhookId">Id of the webhook (required)</param>
        public async Task<Models.BitmovinResponse> DeleteByEncodingIdAndWebhookIdAsync(string encodingId, string webhookId)
        {
            return await _apiClient.DeleteByEncodingIdAndWebhookIdAsync(encodingId, webhookId);
        }

        /// <summary>
        /// Delete Encoding Transfer Error Webhook
        /// </summary>
        /// <param name="webhookId">Id of the webhook (required)</param>
        public async Task<Models.BitmovinResponse> DeleteByWebhookIdAsync(string webhookId)
        {
            return await _apiClient.DeleteByWebhookIdAsync(webhookId);
        }

        /// <summary>
        /// Encoding Transfer Error Webhook Details for specific Encoding Resource
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="webhookId">Id of the webhook (required)</param>
        public async Task<Models.Webhook> GetByEncodingIdAndWebhookIdAsync(string encodingId, string webhookId)
        {
            return await _apiClient.GetByEncodingIdAndWebhookIdAsync(encodingId, webhookId);
        }

        /// <summary>
        /// Encoding Transfer Error Webhook Details
        /// </summary>
        /// <param name="webhookId">Id of the webhook (required)</param>
        public async Task<Models.Webhook> GetByWebhookIdAsync(string webhookId)
        {
            return await _apiClient.GetByWebhookIdAsync(webhookId);
        }

        /// <summary>
        /// List Encoding Transfer-Error Webhooks
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Webhook>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// List Encoding Transfer Error Webhooks for specific Encoding Resource
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Webhook>> ListByEncodingIdAsync(string encodingId, params Func<ListByEncodingIdQueryParams, ListByEncodingIdQueryParams>[] queryParams)
        {
            ListByEncodingIdQueryParams q = new ListByEncodingIdQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListByEncodingIdAsync(encodingId, q);
        }

        internal interface ITransferErrorApiClient
        {
            [Post("/notifications/webhooks/encoding/encodings/transfer-error")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> CreateAsync([Body] Models.Webhook webhook);

            [Post("/notifications/webhooks/encoding/encodings/{encoding_id}/transfer-error")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> CreateByEncodingIdAsync([Path("encoding_id")] string encodingId, [Body] Models.Webhook webhook);

            [Delete("/notifications/webhooks/encoding/encodings/{encoding_id}/transfer-error/{webhook_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteByEncodingIdAndWebhookIdAsync([Path("encoding_id")] string encodingId, [Path("webhook_id")] string webhookId);

            [Delete("/notifications/webhooks/encoding/encodings/transfer-error/{webhook_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteByWebhookIdAsync([Path("webhook_id")] string webhookId);

            [Get("/notifications/webhooks/encoding/encodings/{encoding_id}/transfer-error/{webhook_id}")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> GetByEncodingIdAndWebhookIdAsync([Path("encoding_id")] string encodingId, [Path("webhook_id")] string webhookId);

            [Get("/notifications/webhooks/encoding/encodings/transfer-error/{webhook_id}")]
            [AllowAnyStatusCode]
            Task<Models.Webhook> GetByWebhookIdAsync([Path("webhook_id")] string webhookId);

            [Get("/notifications/webhooks/encoding/encodings/transfer-error")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Webhook>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Get("/notifications/webhooks/encoding/encodings/{encoding_id}/transfer-error")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Webhook>> ListByEncodingIdAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

        public class ListByEncodingIdQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListByEncodingIdQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListByEncodingIdQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListByEncodingIdQueryParams SetQueryParam<T>(string key, T value)
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
