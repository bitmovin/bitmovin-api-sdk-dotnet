using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.Vod.Daily
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
        /// List daily VoD encoding statistics within specific dates
        /// </summary>
        /// <param name="from">Start date, format: yyyy-MM-dd (required)</param>
        /// <param name="to">End date, format: yyyy-MM-dd (required)</param>
        public async Task<Models.PaginationResponse<Models.EncodingStatistics>> ListByDateRangeAsync(DateTime? from, DateTime? to)
        {
            return await _apiClient.ListByDateRangeAsync(from, to);
        }

        internal interface IDailyApiClient
        {
            [Get("/encoding/statistics/encodings/vod/daily/{from}/{to}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EncodingStatistics>> ListByDateRangeAsync([Path("from", Format = "yyyy-MM-dd")] DateTime? from, [Path("to", Format = "yyyy-MM-dd")] DateTime? to);
        }
    }
}
