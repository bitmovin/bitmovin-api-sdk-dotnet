using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Statistics.Labels.Daily;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Labels
{
    public class LabelsApi
    {
        private readonly ILabelsApiClient _apiClient;

        public LabelsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILabelsApiClient>();

            Daily = new DailyApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LabelsApi
        /// </summary>
        public static BitmovinApiBuilder<LabelsApi> Builder => new BitmovinApiBuilder<LabelsApi>();

        public DailyApi Daily { get; private set; }
        
        /// <summary>
        /// Get Statistics per Label
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StatisticsPerLabel>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        /// <summary>
        /// Get statistics per label within specific dates
        /// </summary>
        /// <param name="from">Start date. Format: yyyy-MM-dd</param>
        /// <param name="to">End date. Format: yyyy-MM-dd</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StatisticsPerLabel>> ListByDateRangeAsync(DateTime? from, DateTime? to, params Func<ListByDateRangeQueryParams, ListByDateRangeQueryParams>[] queryParams)
        {
            ListByDateRangeQueryParams q = new ListByDateRangeQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListByDateRangeAsync(from, to, q);
        }
        
        internal interface ILabelsApiClient
        {
            
            [Get("/encoding/statistics/labels/")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StatisticsPerLabel>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
            [Get("/encoding/statistics/labels/{from}/{to}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StatisticsPerLabel>> ListByDateRangeAsync([Path("from", Format = "yyyy-MM-dd")] DateTime? from, [Path("to", Format = "yyyy-MM-dd")] DateTime? to, [QueryMap] IDictionary<String, Object> queryParams);
            
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

            /// <summary>
            /// Comma separated list of labels. Filter results to only show the ones specified
            /// </summary>
            public ListQueryParams Labels(string Labels) => SetQueryParam("labels", Labels);

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

            /// <summary>
            /// Comma separated list of labels. Filter results to only show the ones specified
            /// </summary>
            public ListByDateRangeQueryParams Labels(string Labels) => SetQueryParam("labels", Labels);

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
