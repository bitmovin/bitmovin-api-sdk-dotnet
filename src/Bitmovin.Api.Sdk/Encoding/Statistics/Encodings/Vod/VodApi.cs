using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.Vod.Daily;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.Vod
{
    /// <summary>
    /// API for VodApi
    /// </summary>
    public class VodApi
    {
        private readonly IVodApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the VodApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public VodApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVodApiClient>();
            Daily = new DailyApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of VodApi
        /// </summary>
        public static BitmovinApiBuilder<VodApi> Builder => new BitmovinApiBuilder<VodApi>();

        /// <summary>
        /// Gets the Daily API
        /// </summary>
        public DailyApi Daily { get; }

        /// <summary>
        /// List VOD Encoding Statistics
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EncodingStatisticsVod>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// List VOD Encoding Statistics Within Specific Dates
        /// </summary>
        /// <param name="from">Start date, format: yyyy-MM-dd (required)</param>
        /// <param name="to">End date, format: yyyy-MM-dd (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EncodingStatisticsVod>> ListByDateRangeAsync(DateTime? from, DateTime? to, params Func<ListByDateRangeQueryParams, ListByDateRangeQueryParams>[] queryParams)
        {
            ListByDateRangeQueryParams q = new ListByDateRangeQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListByDateRangeAsync(from, to, q);
        }

        internal interface IVodApiClient
        {
            [Get("/encoding/statistics/encodings/vod")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EncodingStatisticsVod>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Get("/encoding/statistics/encodings/vod/{from}/{to}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EncodingStatisticsVod>> ListByDateRangeAsync([Path("from", Format = "yyyy-MM-dd")] DateTime? from, [Path("to", Format = "yyyy-MM-dd")] DateTime? to, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

        /// <summary>
        /// Query parameters for ListByDateRange
        /// </summary>
        public class ListByDateRangeQueryParams : Dictionary<string,Object>
        {
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
