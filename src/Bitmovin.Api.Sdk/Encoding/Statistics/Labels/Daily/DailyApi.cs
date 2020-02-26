using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Labels.Daily
{
    public class DailyApi
    {
        private readonly IDailyApiClient _apiClient;

        public DailyApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDailyApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DailyApi
        /// </summary>
        public static BitmovinApiBuilder<DailyApi> Builder => new BitmovinApiBuilder<DailyApi>();

        /// <summary>
        /// Get Daily Statistics per Label
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DailyStatisticsPerLabel>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Get daily statistics per label within specific dates
        /// </summary>
        /// <param name="from">Start date. Format: yyyy-MM-dd (required)</param>
        /// <param name="to">End date. Format: yyyy-MM-dd (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DailyStatisticsPerLabel>> ListByDateRangeAsync(DateTime? from, DateTime? to, params Func<ListByDateRangeQueryParams, ListByDateRangeQueryParams>[] queryParams)
        {
            ListByDateRangeQueryParams q = new ListByDateRangeQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListByDateRangeAsync(from, to, q);
        }

        internal interface IDailyApiClient
        {
            [Get("/encoding/statistics/labels/daily")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DailyStatisticsPerLabel>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);

            [Get("/encoding/statistics/labels/daily/{from}/{to}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DailyStatisticsPerLabel>> ListByDateRangeAsync([Path("from", Format = "yyyy-MM-dd")] DateTime? from, [Path("to", Format = "yyyy-MM-dd")] DateTime? to, [QueryMap] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(long? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(long? limit) => SetQueryParam("limit", limit);

            /// <summary>
            /// Comma separated list of labels. Filter results to only show the ones specified
            /// </summary>
            public ListQueryParams Labels(string labels) => SetQueryParam("labels", labels);

            private ListQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }

        public class ListByDateRangeQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListByDateRangeQueryParams Offset(long? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListByDateRangeQueryParams Limit(long? limit) => SetQueryParam("limit", limit);

            /// <summary>
            /// Comma separated list of labels. Filter results to only show the ones specified
            /// </summary>
            public ListByDateRangeQueryParams Labels(string labels) => SetQueryParam("labels", labels);

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
