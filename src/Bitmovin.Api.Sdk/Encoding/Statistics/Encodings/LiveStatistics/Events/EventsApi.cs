using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics.Events
{
    /// <summary>
    /// API for EventsApi
    /// </summary>
    public class EventsApi
    {
        private readonly IEventsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the EventsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public EventsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEventsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of EventsApi
        /// </summary>
        public static BitmovinApiBuilder<EventsApi> Builder => new BitmovinApiBuilder<EventsApi>();

        /// <summary>
        /// List Events of Live Statistics from an Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.LiveEncodingStatsEvent>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IEventsApiClient
        {
            [Get("/encoding/statistics/encodings/{encoding_id}/live-statistics/events")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.LiveEncodingStatsEvent>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
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

            /// <summary>
            /// Sort events by time in DESC order
            /// </summary>
            public ListQueryParams SortByTime(bool? sortByTime) => SetQueryParam("sortByTime", sortByTime);

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
