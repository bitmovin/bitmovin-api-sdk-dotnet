using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Live.InsertableContent.Schedule;
using Bitmovin.Api.Sdk.Encoding.Encodings.Live.InsertableContent.Scheduled;
using Bitmovin.Api.Sdk.Encoding.Encodings.Live.InsertableContent.Stop;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.InsertableContent
{
    public class InsertableContentApi
    {
        private readonly IInsertableContentApiClient _apiClient;

        public InsertableContentApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInsertableContentApiClient>();
            Schedule = new ScheduleApi(apiClientFactory);
            Scheduled = new ScheduledApi(apiClientFactory);
            Stop = new StopApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InsertableContentApi
        /// </summary>
        public static BitmovinApiBuilder<InsertableContentApi> Builder => new BitmovinApiBuilder<InsertableContentApi>();

        public ScheduleApi Schedule { get; }
        public ScheduledApi Scheduled { get; }
        public StopApi Stop { get; }

        /// <summary>
        /// Make Insertable Content Available For A Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="insertableContent">The insertable content to be created</param>
        public async Task<Models.InsertableContent> CreateAsync(string encodingId, Models.InsertableContent insertableContent)
        {
            return await _apiClient.CreateAsync(encodingId, insertableContent);
        }

        /// <summary>
        /// List All Insertable Content Available For A Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.InsertableContent>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IInsertableContentApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/live/insertable-content")]
            [AllowAnyStatusCode]
            Task<Models.InsertableContent> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.InsertableContent insertableContent);

            [Get("/encoding/encodings/{encoding_id}/live/insertable-content")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.InsertableContent>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
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
