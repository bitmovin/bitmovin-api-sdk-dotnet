using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Daily
{
    /// <summary>
    /// API for DailyApi
    /// </summary>
    public class DailyApi
    {
        private readonly IDailyApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DailyApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DailyApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDailyApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DailyApi
        /// </summary>
        public static BitmovinApiBuilder<DailyApi> Builder => new BitmovinApiBuilder<DailyApi>();

        /// <summary>
        /// List Daily Statistics
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DailyStatistics>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// List daily statistics within specific dates
        /// </summary>
        /// <param name="from">Start date, format: yyyy-MM-dd (required)</param>
        /// <param name="to">End date, format: yyyy-MM-dd (required)</param>
        public async Task<Models.PaginationResponse<Models.DailyStatistics>> ListByDateRangeAsync(DateTime? from, DateTime? to)
        {
            return await _apiClient.ListByDateRangeAsync(from, to);
        }

        internal interface IDailyApiClient
        {
            [Get("/encoding/statistics/daily")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DailyStatistics>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Get("/encoding/statistics/daily/{from}/{to}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DailyStatistics>> ListByDateRangeAsync([Path("from", Format = "yyyy-MM-dd")] DateTime? from, [Path("to", Format = "yyyy-MM-dd")] DateTime? to);
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
