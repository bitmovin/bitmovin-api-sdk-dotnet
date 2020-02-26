using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Default
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
        /// Create DASH Manifest Default
        /// </summary>
        /// <param name="dashManifestDefault">The DASH Manifest Default to be created</param>
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
