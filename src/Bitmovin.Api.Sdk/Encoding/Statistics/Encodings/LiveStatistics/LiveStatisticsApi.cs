using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics.Events;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics.Streams;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics.Srt;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics
{
    /// <summary>
    /// API for LiveStatisticsApi
    /// </summary>
    public class LiveStatisticsApi
    {
        private readonly ILiveStatisticsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the LiveStatisticsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public LiveStatisticsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveStatisticsApiClient>();
            Events = new EventsApi(apiClientFactory);
            Streams = new StreamsApi(apiClientFactory);
            Srt = new SrtApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveStatisticsApi
        /// </summary>
        public static BitmovinApiBuilder<LiveStatisticsApi> Builder => new BitmovinApiBuilder<LiveStatisticsApi>();

        /// <summary>
        /// Gets the Events API
        /// </summary>
        public EventsApi Events { get; }
        /// <summary>
        /// Gets the Streams API
        /// </summary>
        public StreamsApi Streams { get; }
        /// <summary>
        /// Gets the Srt API
        /// </summary>
        public SrtApi Srt { get; }

        /// <summary>
        /// List Live Statistics from an Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.LiveEncodingStats> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface ILiveStatisticsApiClient
        {
            [Get("/encoding/statistics/encodings/{encoding_id}/live-statistics")]
            [AllowAnyStatusCode]
            Task<Models.LiveEncodingStats> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
