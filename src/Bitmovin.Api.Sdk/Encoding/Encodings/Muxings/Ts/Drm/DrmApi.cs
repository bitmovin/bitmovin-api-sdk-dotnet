using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm.Fairplay;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm.Aes;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm.Speke;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm
{
    public class DrmApi
    {
        private readonly IDrmApiClient _apiClient;

        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDrmApiClient>();
            Fairplay = new FairplayApi(apiClientFactory);
            Aes = new AesApi(apiClientFactory);
            Speke = new SpekeApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        public FairplayApi Fairplay { get; }
        public AesApi Aes { get; }
        public SpekeApi Speke { get; }

        /// <summary>
        /// DRM Details of a TS muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the TS muxing (required)</param>
        /// <param name="drmId">Id of the DRM. (required)</param>
        public async Task<Models.Drm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// List all DRM configurations of a TS muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the TS muxing (required)</param>
        public async Task<Models.PaginationResponse<Models.Drm>> ListAsync(string encodingId, string muxingId)
        {
            return await _apiClient.ListAsync(encodingId, muxingId);
        }

        internal interface IDrmApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.Drm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Drm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
        }
    }
}
