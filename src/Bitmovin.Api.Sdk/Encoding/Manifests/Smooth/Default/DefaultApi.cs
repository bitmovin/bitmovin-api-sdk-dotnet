using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Default
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
        /// Create Default Smooth Streaming Manifest
        /// </summary>
        /// <param name="smoothManifestDefault">The Default Smooth Streaming Manifest to be created.</param>
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
