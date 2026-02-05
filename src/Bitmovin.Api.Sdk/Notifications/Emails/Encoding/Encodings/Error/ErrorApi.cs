using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Emails.Encoding.Encodings.Error
{
    /// <summary>
    /// API for ErrorApi
    /// </summary>
    public class ErrorApi
    {
        private readonly IErrorApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ErrorApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ErrorApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IErrorApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ErrorApi
        /// </summary>
        public static BitmovinApiBuilder<ErrorApi> Builder => new BitmovinApiBuilder<ErrorApi>();

        /// <summary>
        /// Add Encoding Error Email Notification (All Encodings)
        /// </summary>
        /// <param name="encodingErrorEmailNotification">Add a new email notification if an encoding received an error</param>
        public async Task<Models.PaginationResponse<Models.EncodingErrorEmailNotification>> CreateAsync(Models.EncodingErrorEmailNotification encodingErrorEmailNotification)
        {
            return await _apiClient.CreateAsync(encodingErrorEmailNotification);
        }

        /// <summary>
        /// Add Encoding Error Email Notification (Specific Encoding)
        /// </summary>
        /// <param name="encodingId">Id of the encoding resource (required)</param>
        /// <param name="emailNotification">The email notifications object</param>
        public async Task<Models.EmailNotification> CreateByEncodingIdAsync(string encodingId, Models.EmailNotification emailNotification)
        {
            return await _apiClient.CreateByEncodingIdAsync(encodingId, emailNotification);
        }

        /// <summary>
        /// Replace Encoding Error Email Notification
        /// </summary>
        /// <param name="notificationId">Id of the email notification (required)</param>
        /// <param name="emailNotification">The email notification with the updated values</param>
        public async Task<Models.EmailNotification> UpdateAsync(string notificationId, Models.EmailNotification emailNotification)
        {
            return await _apiClient.UpdateAsync(notificationId, emailNotification);
        }

        internal interface IErrorApiClient
        {
            [Post("/notifications/emails/encoding/encodings/error")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EncodingErrorEmailNotification>> CreateAsync([Body] Models.EncodingErrorEmailNotification encodingErrorEmailNotification);

            [Post("/notifications/emails/encoding/encodings/{encoding_id}/error")]
            [AllowAnyStatusCode]
            Task<Models.EmailNotification> CreateByEncodingIdAsync([Path("encoding_id")] string encodingId, [Body] Models.EmailNotification emailNotification);

            [Put("/notifications/emails/encoding/encodings/error/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.EmailNotification> UpdateAsync([Path("notification_id")] string notificationId, [Body] Models.EmailNotification emailNotification);
        }
    }
}
