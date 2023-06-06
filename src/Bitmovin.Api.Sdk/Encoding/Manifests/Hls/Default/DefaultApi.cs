using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Default
{
    public class DefaultApi
    {
        private readonly IDefaultApiClient _apiClient;

        public DefaultApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDefaultApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DefaultApi
        /// </summary>
        public static BitmovinApiBuilder<DefaultApi> Builder => new BitmovinApiBuilder<DefaultApi>();

        /// <summary>
        /// Create Default HLS Manifest
        /// </summary>
        /// <param name="hlsManifestDefault">A Default Manifest is the easiest way to create a manifest file. Its contents will be configured automatically, depending on what output your encoding creates (muxings, thumbnails, sprites, subtitles, DRM information). If you need more control, create a Custom Manifest resource instead. See [documentation](https://developer.bitmovin.com/encoding/docs/default-vs-custom-manifest) page for a comparison</param>
        public async Task<Models.HlsManifestDefault> CreateAsync(Models.HlsManifestDefault hlsManifestDefault)
        {
            return await _apiClient.CreateAsync(hlsManifestDefault);
        }

        internal interface IDefaultApiClient
        {
            [Post("/encoding/manifests/hls/default")]
            [AllowAnyStatusCode]
            Task<Models.HlsManifestDefault> CreateAsync([Body] Models.HlsManifestDefault hlsManifestDefault);
        }
    }
}
