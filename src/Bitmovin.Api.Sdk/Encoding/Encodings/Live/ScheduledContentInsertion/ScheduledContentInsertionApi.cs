using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.ScheduledContentInsertion
{
    public class ScheduledContentInsertionApi
    {
        private readonly IScheduledContentInsertionApiClient _apiClient;

        public ScheduledContentInsertionApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IScheduledContentInsertionApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of ScheduledContentInsertionApi
        /// </summary>
        public static BitmovinApiBuilder<ScheduledContentInsertionApi> Builder => new BitmovinApiBuilder<ScheduledContentInsertionApi>();

        
        /// <summary>
        /// Schedule A Content Insertion For a Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="scheduledContentInsertion">The request payload</param>
        public async Task<Models.ScheduledContentInsertion> CreateAsync(string encodingId, Models.ScheduledContentInsertion scheduledContentInsertion)
        {
            return await _apiClient.CreateAsync(encodingId, scheduledContentInsertion);
        }
        
        /// <summary>
        /// Deschedule A Content Insertion
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="contentInsertionId">Id of the scheduled content insertion</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string contentInsertionId)
        {
            return await _apiClient.DeleteAsync(encodingId, contentInsertionId);
        }
        
        /// <summary>
        /// Delete All Scheduled Content Insertions For A Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        public async Task DeleteByEncodingIdAsync(string encodingId)
        {
            await _apiClient.DeleteByEncodingIdAsync(encodingId);
        }
        
        /// <summary>
        /// List All Scheduled Content Insertions For A Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ScheduledContentInsertion>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IScheduledContentInsertionApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/live/scheduled-content-insertion")]
            [AllowAnyStatusCode]
            Task<Models.ScheduledContentInsertion> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ScheduledContentInsertion scheduledContentInsertion);
            
            [Delete("/encoding/encodings/{encoding_id}/live/scheduled-content-insertion/{content_insertion_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("content_insertion_id")] string contentInsertionId);
            
            [Delete("/encoding/encodings/{encoding_id}/live/scheduled-content-insertion")]
            [AllowAnyStatusCode]
            Task DeleteByEncodingIdAsync([Path("encoding_id")] string encodingId);
            
            [Get("/encoding/encodings/{encoding_id}/live/scheduled-content-insertion")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ScheduledContentInsertion>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

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
