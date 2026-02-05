using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.InsertableContent.Stop
{
    /// <summary>
    /// API for StopApi
    /// </summary>
    public class StopApi
    {
        private readonly IStopApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the StopApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public StopApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStopApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of StopApi
        /// </summary>
        public static BitmovinApiBuilder<StopApi> Builder => new BitmovinApiBuilder<StopApi>();

        /// <summary>
        /// Stops currently running Inserted Content
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task CreateAsync(string encodingId)
        {
            await _apiClient.CreateAsync(encodingId);
        }

        internal interface IStopApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/live/insertable-content/stop")]
            [AllowAnyStatusCode]
            Task CreateAsync([Path("encoding_id")] string encodingId);
        }
    }
}
