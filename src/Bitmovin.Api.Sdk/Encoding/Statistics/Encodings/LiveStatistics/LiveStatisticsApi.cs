using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics.Events;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics.Streams;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics
{
    public class LiveStatisticsApi
    {
        private readonly ILiveStatisticsApiClient _apiClient;

        public LiveStatisticsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveStatisticsApiClient>();

            Events = new EventsApi(apiClientFactory);
            Streams = new StreamsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveStatisticsApi
        /// </summary>
        public static BitmovinApiBuilder<LiveStatisticsApi> Builder => new BitmovinApiBuilder<LiveStatisticsApi>();

        public EventsApi Events { get; private set; }
        public StreamsApi Streams { get; private set; }
        
        /// <summary>
        /// List Live Statistics from an Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
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
