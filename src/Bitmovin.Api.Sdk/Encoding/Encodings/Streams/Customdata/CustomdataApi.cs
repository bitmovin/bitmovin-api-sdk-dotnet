using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Customdata
{
    /// <summary>
    /// API for CustomdataApi
    /// </summary>
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the CustomdataApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        /// <summary>
        /// Stream Custom Data
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        public async Task<Models.CustomData> GetAsync(string encodingId, string streamId)
        {
            return await _apiClient.GetAsync(encodingId, streamId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId);
        }
    }
}
