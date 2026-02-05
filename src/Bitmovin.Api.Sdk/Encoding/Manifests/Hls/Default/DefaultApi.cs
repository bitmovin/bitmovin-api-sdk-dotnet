using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Default
{
    /// <summary>
    /// API for DefaultApi
    /// </summary>
    public class DefaultApi
    {
        private readonly IDefaultApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DefaultApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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
        /// <param name="hlsManifestDefault">The Default HLS Manifest to be created.</param>
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
