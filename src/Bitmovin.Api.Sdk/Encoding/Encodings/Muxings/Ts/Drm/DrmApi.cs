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

        public FairplayApi Fairplay { get; private set; }
        public AesApi Aes { get; private set; }
        public SpekeApi Speke { get; private set; }
        
        /// <summary>
        /// List all DRM configurations of TS Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the TS muxing</param>
        public async Task<Models.PaginationResponse<Models.Drm>> ListAsync(string encodingId, string muxingId)
        {
            return await _apiClient.ListAsync(encodingId, muxingId);
        }
        
        internal interface IDrmApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Drm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
        }
        
    }
}
