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
        /// Create HLS Manifest Default
        /// </summary>
        /// <param name="hlsManifestDefault">The HLS Manifest to be created</param>
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
