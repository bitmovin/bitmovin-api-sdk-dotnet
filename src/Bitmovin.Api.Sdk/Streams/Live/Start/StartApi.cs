using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.Live.Start
{
    /// <summary>
    /// API for StartApi
    /// </summary>
    public class StartApi
    {
        private readonly IStartApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the StartApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public StartApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStartApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of StartApi
        /// </summary>
        public static BitmovinApiBuilder<StartApi> Builder => new BitmovinApiBuilder<StartApi>();

        /// <summary>
        /// Start live stream by id
        /// </summary>
        /// <param name="streamId">Id of the stream. (required)</param>
        public async Task UpdateAsync(string streamId)
        {
            await _apiClient.UpdateAsync(streamId);
        }

        internal interface IStartApiClient
        {
            [Put("/streams/live/{stream_id}/start")]
            [AllowAnyStatusCode]
            Task UpdateAsync([Path("stream_id")] string streamId);
        }
    }
}
