using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.Live.Stop
{
    public class StopApi
    {
        private readonly IStopApiClient _apiClient;

        public StopApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStopApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of StopApi
        /// </summary>
        public static BitmovinApiBuilder<StopApi> Builder => new BitmovinApiBuilder<StopApi>();

        /// <summary>
        /// Stop live stream by id
        /// </summary>
        /// <param name="streamId">Id of the stream. (required)</param>
        public async Task UpdateAsync(string streamId)
        {
            await _apiClient.UpdateAsync(streamId);
        }

        internal interface IStopApiClient
        {
            [Put("/streams/live/{stream_id}/stop")]
            [AllowAnyStatusCode]
            Task UpdateAsync([Path("stream_id")] string streamId);
        }
    }
}
