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
    public class EncodingsApi
    {
        private readonly IEncodingsApiClient _apiClient;

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

        public LiveApi Live { get; private set; }
        public VodApi Vod { get; private set; }
        public LiveStatisticsApi LiveStatistics { get; private set; }
        
        /// <summary>
        /// Get Statistics from an Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
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
