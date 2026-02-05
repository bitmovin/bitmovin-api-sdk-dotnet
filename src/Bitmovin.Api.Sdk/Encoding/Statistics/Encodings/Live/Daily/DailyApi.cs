using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.Live.Daily
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
        /// List daily live encoding statistics within specific dates
        /// </summary>
        /// <param name="from">Start date, format: yyyy-MM-dd (required)</param>
        /// <param name="to">End date, format: yyyy-MM-dd (required)</param>
        public async Task<Models.PaginationResponse<Models.EncodingStatisticsLive>> ListByDateRangeAsync(DateTime? from, DateTime? to)
        {
            return await _apiClient.ListByDateRangeAsync(from, to);
        }

        internal interface IDailyApiClient
        {
            [Get("/encoding/statistics/encodings/live/daily/{from}/{to}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EncodingStatisticsLive>> ListByDateRangeAsync([Path("from", Format = "yyyy-MM-dd")] DateTime? from, [Path("to", Format = "yyyy-MM-dd")] DateTime? to);
        }
    }
}
