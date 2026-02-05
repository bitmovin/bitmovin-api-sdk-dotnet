using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Default
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
        /// Create Default DASH Manifest
        /// </summary>
        /// <param name="dashManifestDefault">The Default DASH Manifest to be created.</param>
        public async Task<Models.DashManifestDefault> CreateAsync(Models.DashManifestDefault dashManifestDefault)
        {
            return await _apiClient.CreateAsync(dashManifestDefault);
        }

        internal interface IDefaultApiClient
        {
            [Post("/encoding/manifests/dash/default")]
            [AllowAnyStatusCode]
            Task<Models.DashManifestDefault> CreateAsync([Body] Models.DashManifestDefault dashManifestDefault);
        }
    }
}
