using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.InsertableContent.Schedule
{
    /// <summary>
    /// API for ScheduleApi
    /// </summary>
    public class ScheduleApi
    {
        private readonly IScheduleApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ScheduleApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ScheduleApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IScheduleApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ScheduleApi
        /// </summary>
        public static BitmovinApiBuilder<ScheduleApi> Builder => new BitmovinApiBuilder<ScheduleApi>();

        /// <summary>
        /// Schedule Insertable Content
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="contentId">Id of the insertable content. (required)</param>
        /// <param name="scheduledInsertableContent">The scheduled insertable content to be created</param>
        public async Task<Models.ScheduledInsertableContent> CreateAsync(string encodingId, string contentId, Models.ScheduledInsertableContent scheduledInsertableContent)
        {
            return await _apiClient.CreateAsync(encodingId, contentId, scheduledInsertableContent);
        }

        /// <summary>
        /// Deschedule Insertable Content
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="contentId">Id of the insertable content. (required)</param>
        /// <param name="scheduledContentId">Id of the scheduled insertable content (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string contentId, string scheduledContentId)
        {
            return await _apiClient.DeleteAsync(encodingId, contentId, scheduledContentId);
        }

        internal interface IScheduleApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/live/insertable-content/{content_id}/schedule")]
            [AllowAnyStatusCode]
            Task<Models.ScheduledInsertableContent> CreateAsync([Path("encoding_id")] string encodingId, [Path("content_id")] string contentId, [Body] Models.ScheduledInsertableContent scheduledInsertableContent);

            [Delete("/encoding/encodings/{encoding_id}/live/insertable-content/{content_id}/schedule/{scheduled_content_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("content_id")] string contentId, [Path("scheduled_content_id")] string scheduledContentId);
        }
    }
}
