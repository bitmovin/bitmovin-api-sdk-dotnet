using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks;
using Bitmovin.Api.Sdk.Notifications.States;
using Bitmovin.Api.Sdk.Notifications.Emails;

namespace Bitmovin.Api.Sdk.Notifications
{
    public class NotificationsApi
    {
        private readonly INotificationsApiClient _apiClient;

        public NotificationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<INotificationsApiClient>();
            Webhooks = new WebhooksApi(apiClientFactory);
            States = new StatesApi(apiClientFactory);
            Emails = new EmailsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of NotificationsApi
        /// </summary>
        public static BitmovinApiBuilder<NotificationsApi> Builder => new BitmovinApiBuilder<NotificationsApi>();

        public WebhooksApi Webhooks { get; }
        public StatesApi States { get; }
        public EmailsApi Emails { get; }

        /// <summary>
        /// Delete Notification
        /// </summary>
        /// <param name="notificationId">Id of the notification (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string notificationId)
        {
            return await _apiClient.DeleteAsync(notificationId);
        }

        /// <summary>
        /// Get Notification
        /// </summary>
        /// <param name="notificationId">Id of the notification (required)</param>
        public async Task<Models.Notification> GetAsync(string notificationId)
        {
            return await _apiClient.GetAsync(notificationId);
        }

        /// <summary>
        /// List Notifications
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Notification>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// List Notification State History (All Resources)
        /// </summary>
        /// <param name="notificationId">Id of the notification (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.NotificationStateEntry>> ListByNotificationIdAsync(string notificationId, params Func<ListByNotificationIdQueryParams, ListByNotificationIdQueryParams>[] queryParams)
        {
            ListByNotificationIdQueryParams q = new ListByNotificationIdQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListByNotificationIdAsync(notificationId, q);
        }

        /// <summary>
        /// Mute Notification
        /// </summary>
        /// <param name="notificationId">Id of the notification (required)</param>
        public async Task<Models.BitmovinResponse> MuteAsync(string notificationId)
        {
            return await _apiClient.MuteAsync(notificationId);
        }

        /// <summary>
        /// Unmute Notification
        /// </summary>
        /// <param name="notificationId">Id of the notification (required)</param>
        public async Task<Models.BitmovinResponse> UnmuteAsync(string notificationId)
        {
            return await _apiClient.UnmuteAsync(notificationId);
        }

        internal interface INotificationsApiClient
        {
            [Delete("/notifications/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("notification_id")] string notificationId);

            [Get("/notifications/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.Notification> GetAsync([Path("notification_id")] string notificationId);

            [Get("/notifications")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Notification>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Get("/notifications/{notification_id}/states")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.NotificationStateEntry>> ListByNotificationIdAsync([Path("notification_id")] string notificationId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Post("/notifications/{notification_id}/mute")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> MuteAsync([Path("notification_id")] string notificationId);

            [Post("/notifications/{notification_id}/unmute")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> UnmuteAsync([Path("notification_id")] string notificationId);
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

        public class ListByNotificationIdQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListByNotificationIdQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListByNotificationIdQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListByNotificationIdQueryParams SetQueryParam<T>(string key, T value)
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
