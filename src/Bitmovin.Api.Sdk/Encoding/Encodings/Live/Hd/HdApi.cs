using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.Hd
{
    public class HdApi
    {
        private readonly IHdApiClient _apiClient;

        public HdApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHdApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of HdApi
        /// </summary>
        public static BitmovinApiBuilder<HdApi> Builder => new BitmovinApiBuilder<HdApi>();

        /// <summary>
        /// Live Encoding Start Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        public async Task<Models.StartLiveChannelEncodingRequest> GetStartRequestAsync(string encodingId)
        {
            return await _apiClient.GetStartRequestAsync(encodingId);
        }

        /// <summary>
        /// Start HD Options Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="startLiveChannelEncodingRequest">Live Encoding startup options</param>
        public async Task<Models.BitmovinResponse> StartAsync(string encodingId, Models.StartLiveChannelEncodingRequest startLiveChannelEncodingRequest)
        {
            return await _apiClient.StartAsync(encodingId, startLiveChannelEncodingRequest);
        }

        internal interface IHdApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/live/hd/start")]
            [AllowAnyStatusCode]
            Task<Models.StartLiveChannelEncodingRequest> GetStartRequestAsync([Path("encoding_id")] string encodingId);

            [Post("/encoding/encodings/{encoding_id}/live/hd/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("encoding_id")] string encodingId, [Body] Models.StartLiveChannelEncodingRequest startLiveChannelEncodingRequest);
        }
    }
}
