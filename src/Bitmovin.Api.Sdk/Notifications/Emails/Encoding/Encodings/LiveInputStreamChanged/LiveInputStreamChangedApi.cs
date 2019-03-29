using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.Emails.Encoding.Encodings.LiveInputStreamChanged
{
    public class LiveInputStreamChangedApi
    {
        private readonly ILiveInputStreamChangedApiClient _apiClient;

        public LiveInputStreamChangedApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveInputStreamChangedApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveInputStreamChangedApi
        /// </summary>
        public static BitmovinApiBuilder<LiveInputStreamChangedApi> Builder => new BitmovinApiBuilder<LiveInputStreamChangedApi>();

        
        /// <summary>
        /// Add Live Input Stream Changed Email Notification (All Encodings)
        /// </summary>
        /// <param name="emailNotificationWithStreamConditions">The request payload</param>
        public async Task<Models.EmailNotificationWithStreamConditions> CreateAsync(Models.EmailNotificationWithStreamConditions emailNotificationWithStreamConditions)
        {
            return await _apiClient.CreateAsync(emailNotificationWithStreamConditions);
        }
        
        /// <summary>
        /// Add Live Input Stream Changed Email Notification (Specific Encoding)
        /// </summary>
        /// <param name="encodingId">Id of the encoding resource</param>
        /// <param name="emailNotificationWithStreamConditions">The request payload</param>
        public async Task<Models.EmailNotificationWithStreamConditions> CreateByEncodingIdAsync(string encodingId, Models.EmailNotificationWithStreamConditions emailNotificationWithStreamConditions)
        {
            return await _apiClient.CreateByEncodingIdAsync(encodingId, emailNotificationWithStreamConditions);
        }
        
        /// <summary>
        /// Replace Live Input Stream Changed Email Notification
        /// </summary>
        /// <param name="notificationId">Id of the email notification</param>
        /// <param name="emailNotificationWithStreamConditions">The request payload</param>
        public async Task<Models.EmailNotificationWithStreamConditions> UpdateAsync(string notificationId, Models.EmailNotificationWithStreamConditions emailNotificationWithStreamConditions)
        {
            return await _apiClient.UpdateAsync(notificationId, emailNotificationWithStreamConditions);
        }
        
        internal interface ILiveInputStreamChangedApiClient
        {
            
            [Post("/notifications/emails/encoding/encodings/live-input-stream-changed")]
            [AllowAnyStatusCode]
            Task<Models.EmailNotificationWithStreamConditions> CreateAsync([Body] Models.EmailNotificationWithStreamConditions emailNotificationWithStreamConditions);
            
            [Post("/notifications/emails/encoding/encodings/{encoding_id}/live-input-stream-changed")]
            [AllowAnyStatusCode]
            Task<Models.EmailNotificationWithStreamConditions> CreateByEncodingIdAsync([Path("encoding_id")] string encodingId, [Body] Models.EmailNotificationWithStreamConditions emailNotificationWithStreamConditions);
            
            [Put("/notifications/emails/encoding/encodings/live-input-stream-changed/{notification_id}")]
            [AllowAnyStatusCode]
            Task<Models.EmailNotificationWithStreamConditions> UpdateAsync([Path("notification_id")] string notificationId, [Body] Models.EmailNotificationWithStreamConditions emailNotificationWithStreamConditions);
            
        }
        
    }
}
