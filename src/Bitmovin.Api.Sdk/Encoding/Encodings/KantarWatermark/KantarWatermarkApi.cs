using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.KantarWatermark
{
    /// <summary>
    /// API for KantarWatermarkApi
    /// </summary>
    public class KantarWatermarkApi
    {
        private readonly IKantarWatermarkApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the KantarWatermarkApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public KantarWatermarkApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IKantarWatermarkApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of KantarWatermarkApi
        /// </summary>
        public static BitmovinApiBuilder<KantarWatermarkApi> Builder => new BitmovinApiBuilder<KantarWatermarkApi>();

        /// <summary>
        /// Create or replace the Kantar Watermark for an encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="kantarWatermark">The Kantar Watermark to be created</param>
        public async Task<Models.KantarWatermark> CreateAsync(string encodingId, Models.KantarWatermark kantarWatermark)
        {
            return await _apiClient.CreateAsync(encodingId, kantarWatermark);
        }

        /// <summary>
        /// Delete the Kantar Watermark for an encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId)
        {
            return await _apiClient.DeleteAsync(encodingId);
        }

        /// <summary>
        /// Get the Kantar Watermark for an encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.KantarWatermark> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface IKantarWatermarkApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/kantar-watermark")]
            [AllowAnyStatusCode]
            Task<Models.KantarWatermark> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.KantarWatermark kantarWatermark);

            [Delete("/encoding/encodings/{encoding_id}/kantar-watermark")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId);

            [Get("/encoding/encodings/{encoding_id}/kantar-watermark")]
            [AllowAnyStatusCode]
            Task<Models.KantarWatermark> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
