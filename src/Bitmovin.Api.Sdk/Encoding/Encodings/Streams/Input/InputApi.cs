using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Input
{
    public class InputApi
    {
        private readonly IInputApiClient _apiClient;

        public InputApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInputApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of InputApi
        /// </summary>
        public static BitmovinApiBuilder<InputApi> Builder => new BitmovinApiBuilder<InputApi>();

        /// <summary>
        /// Stream Input Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        public async Task<Models.EncodingStreamInputDetails> GetAsync(string encodingId, string streamId)
        {
            return await _apiClient.GetAsync(encodingId, streamId);
        }

        internal interface IInputApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/input")]
            [AllowAnyStatusCode]
            Task<Models.EncodingStreamInputDetails> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId);
        }
    }
}
