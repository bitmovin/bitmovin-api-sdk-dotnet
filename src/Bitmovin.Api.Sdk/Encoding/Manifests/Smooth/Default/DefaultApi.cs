using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Default
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
        /// Create Default Smooth Streaming Manifest
        /// </summary>
        /// <param name="smoothManifestDefault">A Default Manifest is the easiest way to create a manifest file. Its contents will be configured automatically, depending on what output your encoding creates (muxings, thumbnails, sprites, subtitles, DRM information). If you need more control, create a Custom Manifest instead. See TODO: link</param>
        public async Task<Models.SmoothManifestDefault> CreateAsync(Models.SmoothManifestDefault smoothManifestDefault)
        {
            return await _apiClient.CreateAsync(smoothManifestDefault);
        }

        internal interface IDefaultApiClient
        {
            [Post("/encoding/manifests/smooth/default")]
            [AllowAnyStatusCode]
            Task<Models.SmoothManifestDefault> CreateAsync([Body] Models.SmoothManifestDefault smoothManifestDefault);
        }
    }
}
