using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.Live.Options
{
    /// <summary>
    /// API for OptionsApi
    /// </summary>
    public class OptionsApi
    {
        private readonly IOptionsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the OptionsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public OptionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IOptionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of OptionsApi
        /// </summary>
        public static BitmovinApiBuilder<OptionsApi> Builder => new BitmovinApiBuilder<OptionsApi>();

        /// <summary>
        /// List live options encoding statistics for a given encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        public async Task<Models.LiveEncodingOptionsStatistics> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        /// <summary>
        /// List live options encoding statistics within specific dates
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.LiveOptionsStatistics> ListByDateRangeAsync(params Func<ListByDateRangeQueryParams, ListByDateRangeQueryParams>[] queryParams)
        {
            ListByDateRangeQueryParams q = new ListByDateRangeQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListByDateRangeAsync(q);
        }

        internal interface IOptionsApiClient
        {
            [Get("/encoding/statistics/encodings/live/{encoding_id}/options")]
            [AllowAnyStatusCode]
            Task<Models.LiveEncodingOptionsStatistics> GetAsync([Path("encoding_id")] string encodingId);

            [Get("/encoding/statistics/encodings/live/options")]
            [AllowAnyStatusCode]
            Task<Models.LiveOptionsStatistics> ListByDateRangeAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for ListByDateRange
        /// </summary>
        public class ListByDateRangeQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Start date, format: yyyy-MM-dd
            /// </summary>
            public ListByDateRangeQueryParams From(DateTime? from) => SetQueryParam("from", from);

            /// <summary>
            /// End date, format: yyyy-MM-dd
            /// </summary>
            public ListByDateRangeQueryParams To(DateTime? to) => SetQueryParam("to", to);

            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListByDateRangeQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListByDateRangeQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListByDateRangeQueryParams SetQueryParam<T>(string key, T value)
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
