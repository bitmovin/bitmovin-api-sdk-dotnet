using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Statistics.Cdn;
using Bitmovin.Api.Sdk.Encoding.Statistics.Daily;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings;
using Bitmovin.Api.Sdk.Encoding.Statistics.Labels;

namespace Bitmovin.Api.Sdk.Encoding.Statistics
{
    /// <summary>
    /// API for StatisticsApi
    /// </summary>
    public class StatisticsApi
    {
        private readonly IStatisticsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the StatisticsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public StatisticsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStatisticsApiClient>();
            Cdn = new CdnApi(apiClientFactory);
            Daily = new DailyApi(apiClientFactory);
            Encodings = new EncodingsApi(apiClientFactory);
            Labels = new LabelsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of StatisticsApi
        /// </summary>
        public static BitmovinApiBuilder<StatisticsApi> Builder => new BitmovinApiBuilder<StatisticsApi>();

        /// <summary>
        /// Gets the Cdn API
        /// </summary>
        public CdnApi Cdn { get; }
        /// <summary>
        /// Gets the Daily API
        /// </summary>
        public DailyApi Daily { get; }
        /// <summary>
        /// Gets the Encodings API
        /// </summary>
        public EncodingsApi Encodings { get; }
        /// <summary>
        /// Gets the Labels API
        /// </summary>
        public LabelsApi Labels { get; }

        /// <summary>
        /// Show Overall Statistics
        /// </summary>
        public async Task<Models.Statistics> GetAsync()
        {
            return await _apiClient.GetAsync();
        }

        /// <summary>
        /// Show Overall Statistics Within Specific Dates
        /// </summary>
        /// <param name="from">Start date, format: yyyy-MM-dd (required)</param>
        /// <param name="to">End date, format: yyyy-MM-dd (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Statistics>> ListAsync(DateTime? from, DateTime? to, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(from, to, q);
        }

        internal interface IStatisticsApiClient
        {
            [Get("/encoding/statistics")]
            [AllowAnyStatusCode]
            Task<Models.Statistics> GetAsync();

            [Get("/encoding/statistics/{from}/{to}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Statistics>> ListAsync([Path("from", Format = "yyyy-MM-dd")] DateTime? from, [Path("to", Format = "yyyy-MM-dd")] DateTime? to, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
