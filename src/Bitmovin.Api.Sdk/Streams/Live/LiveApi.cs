using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.Live
{
    public class LiveApi
    {
        private readonly ILiveApiClient _apiClient;

        public LiveApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveApi
        /// </summary>
        public static BitmovinApiBuilder<LiveApi> Builder => new BitmovinApiBuilder<LiveApi>();

        /// <summary>
        /// Update live stream by id
        /// </summary>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="streamsLiveUpdateRequest">Stream fields to update.</param>
        public async Task<Models.StreamsLiveUpdateRequest> PatchStreamsLiveAsync(string streamId, Models.StreamsLiveUpdateRequest streamsLiveUpdateRequest)
        {
            return await _apiClient.PatchStreamsLiveAsync(streamId, streamsLiveUpdateRequest);
        }

        internal interface ILiveApiClient
        {
            [Patch("/streams/live/{stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsLiveUpdateRequest> PatchStreamsLiveAsync([Path("stream_id")] string streamId, [Body] Models.StreamsLiveUpdateRequest streamsLiveUpdateRequest);
        }
    }
}
