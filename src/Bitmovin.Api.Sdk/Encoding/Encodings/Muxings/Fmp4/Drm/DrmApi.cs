using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Widevine;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Playready;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Primetime;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Fairplay;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Marlin;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Clearkey;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Cenc;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Aes;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm.Speke;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm
{
    /// <summary>
    /// API for DrmApi
    /// </summary>
    public class DrmApi
    {
        private readonly IDrmApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DrmApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDrmApiClient>();
            Widevine = new WidevineApi(apiClientFactory);
            Playready = new PlayreadyApi(apiClientFactory);
            Primetime = new PrimetimeApi(apiClientFactory);
            Fairplay = new FairplayApi(apiClientFactory);
            Marlin = new MarlinApi(apiClientFactory);
            Clearkey = new ClearkeyApi(apiClientFactory);
            Cenc = new CencApi(apiClientFactory);
            Aes = new AesApi(apiClientFactory);
            Speke = new SpekeApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        /// <summary>
        /// Gets the Widevine API
        /// </summary>
        public WidevineApi Widevine { get; }
        /// <summary>
        /// Gets the Playready API
        /// </summary>
        public PlayreadyApi Playready { get; }
        /// <summary>
        /// Gets the Primetime API
        /// </summary>
        public PrimetimeApi Primetime { get; }
        /// <summary>
        /// Gets the Fairplay API
        /// </summary>
        public FairplayApi Fairplay { get; }
        /// <summary>
        /// Gets the Marlin API
        /// </summary>
        public MarlinApi Marlin { get; }
        /// <summary>
        /// Gets the Clearkey API
        /// </summary>
        public ClearkeyApi Clearkey { get; }
        /// <summary>
        /// Gets the Cenc API
        /// </summary>
        public CencApi Cenc { get; }
        /// <summary>
        /// Gets the Aes API
        /// </summary>
        public AesApi Aes { get; }
        /// <summary>
        /// Gets the Speke API
        /// </summary>
        public SpekeApi Speke { get; }

        /// <summary>
        /// DRM Details of an fMP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the fMP4 muxing (required)</param>
        /// <param name="drmId">Id of the DRM. (required)</param>
        public async Task<Models.Drm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }

        /// <summary>
        /// List all DRMs of an fMP4 muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the fMP4 muxing (required)</param>
        public async Task<Models.PaginationResponse<Models.Drm>> ListAsync(string encodingId, string muxingId)
        {
            return await _apiClient.ListAsync(encodingId, muxingId);
        }

        internal interface IDrmApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.Drm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);

            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}/drm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Drm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
        }
    }
}
