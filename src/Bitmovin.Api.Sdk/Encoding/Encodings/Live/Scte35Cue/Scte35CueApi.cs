using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.Scte35Cue
{
    /// <summary>
    /// API for Scte35CueApi
    /// </summary>
    public class Scte35CueApi
    {
        private readonly IScte35CueApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the Scte35CueApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public Scte35CueApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IScte35CueApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of Scte35CueApi
        /// </summary>
        public static BitmovinApiBuilder<Scte35CueApi> Builder => new BitmovinApiBuilder<Scte35CueApi>();

        /// <summary>
        /// Insert cue duration
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="scte35Cue">Cue duration and manifest ids.</param>
        public async Task<Models.Scte35Cue> CreateAsync(string encodingId, Models.Scte35Cue scte35Cue)
        {
            return await _apiClient.CreateAsync(encodingId, scte35Cue);
        }

        internal interface IScte35CueApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/live/scte-35-cue")]
            [AllowAnyStatusCode]
            Task<Models.Scte35Cue> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Scte35Cue scte35Cue);
        }
    }
}
