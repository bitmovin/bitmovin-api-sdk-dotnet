using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Playready;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Clearkey;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Widevine;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Marlin;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Cenc;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm
{
    public class DrmApi
    {
        private readonly IDrmApiClient _apiClient;

        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDrmApiClient>();

            Playready = new PlayreadyApi(apiClientFactory);
            Clearkey = new ClearkeyApi(apiClientFactory);
            Widevine = new WidevineApi(apiClientFactory);
            Marlin = new MarlinApi(apiClientFactory);
            Cenc = new CencApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        public PlayreadyApi Playready { get; private set; }
        public ClearkeyApi Clearkey { get; private set; }
        public WidevineApi Widevine { get; private set; }
        public MarlinApi Marlin { get; private set; }
        public CencApi Cenc { get; private set; }
        
        /// <summary>
        /// List all DRM configurations of MP4 Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the MP4 muxing</param>
        public async Task<Models.PaginationResponse<Models.Drm>> ListAsync(string encodingId, string muxingId)
        {
            return await _apiClient.ListAsync(encodingId, muxingId);
        }
        
        internal interface IDrmApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Drm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
        }
        
    }
}
