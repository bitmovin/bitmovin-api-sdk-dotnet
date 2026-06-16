using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.HeartbeatFinal
{
    /// <summary>
    /// API for HeartbeatFinalApi
    /// </summary>
    public class HeartbeatFinalApi
    {
        private readonly IHeartbeatFinalApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the HeartbeatFinalApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public HeartbeatFinalApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHeartbeatFinalApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of HeartbeatFinalApi
        /// </summary>
        public static BitmovinApiBuilder<HeartbeatFinalApi> Builder => new BitmovinApiBuilder<HeartbeatFinalApi>();

        /// <summary>
        /// Get Final Live Encoding Heartbeat Download URL
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.LiveEncodingHeartbeatUrlResponse> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface IHeartbeatFinalApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/live/heartbeat-final")]
            [AllowAnyStatusCode]
            Task<Models.LiveEncodingHeartbeatUrlResponse> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
