using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.Heartbeat
{
    public class HeartbeatApi
    {
        private readonly IHeartbeatApiClient _apiClient;

        public HeartbeatApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHeartbeatApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of HeartbeatApi
        /// </summary>
        public static BitmovinApiBuilder<HeartbeatApi> Builder => new BitmovinApiBuilder<HeartbeatApi>();

        /// <summary>
        /// Live Encoding Heartbeat
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.LiveEncodingHeartbeat> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface IHeartbeatApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/live/heartbeat")]
            [AllowAnyStatusCode]
            Task<Models.LiveEncodingHeartbeat> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
