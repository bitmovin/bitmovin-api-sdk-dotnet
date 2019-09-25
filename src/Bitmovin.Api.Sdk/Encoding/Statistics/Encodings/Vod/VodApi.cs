using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.Vod
{
    public class VodApi
    {
        private readonly IVodApiClient _apiClient;

        public VodApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVodApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of VodApi
        /// </summary>
        public static BitmovinApiBuilder<VodApi> Builder => new BitmovinApiBuilder<VodApi>();

        
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
        /// <param name="from">Start date, format: yyyy-MM-dd</param>
        /// <param name="to">End date, format: yyyy-MM-dd</param>
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
            Task<Models.PaginationResponse<Models.EncodingStatisticsVod>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
            [Get("/encoding/statistics/encodings/vod/{from}/{to}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EncodingStatisticsVod>> ListByDateRangeAsync([Path("from", Format = "yyyy-MM-dd")] DateTime? from, [Path("to", Format = "yyyy-MM-dd")] DateTime? to, [QueryMap] IDictionary<String, Object> queryParams);
            
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
        public class ListByDateRangeQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListByDateRangeQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListByDateRangeQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

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
