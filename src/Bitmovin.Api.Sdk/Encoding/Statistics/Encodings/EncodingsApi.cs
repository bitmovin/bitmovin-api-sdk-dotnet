using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.Live;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.Vod;
using Bitmovin.Api.Sdk.Encoding.Statistics.Encodings.LiveStatistics;

namespace Bitmovin.Api.Sdk.Encoding.Statistics.Encodings
{
    /// <summary>
    /// API for EncodingsApi
    /// </summary>
    public class EncodingsApi
    {
        private readonly IEncodingsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the EncodingsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public EncodingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEncodingsApiClient>();
            Live = new LiveApi(apiClientFactory);
            Vod = new VodApi(apiClientFactory);
            LiveStatistics = new LiveStatisticsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingsApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingsApi> Builder => new BitmovinApiBuilder<EncodingsApi>();

        /// <summary>
        /// Gets the Live API
        /// </summary>
        public LiveApi Live { get; }
        /// <summary>
        /// Gets the Vod API
        /// </summary>
        public VodApi Vod { get; }
        /// <summary>
        /// Gets the LiveStatistics API
        /// </summary>
        public LiveStatisticsApi LiveStatistics { get; }

        /// <summary>
        /// Get Statistics from an Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        public async Task<Models.EncodingStats> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface IEncodingsApiClient
        {
            [Get("/encoding/statistics/encodings/{encoding_id}")]
            [AllowAnyStatusCode]
            Task<Models.EncodingStats> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
