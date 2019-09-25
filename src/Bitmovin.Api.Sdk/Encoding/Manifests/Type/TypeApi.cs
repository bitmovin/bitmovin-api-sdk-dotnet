using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Type
{
    public class TypeApi
    {
        private readonly ITypeApiClient _apiClient;

        public TypeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITypeApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of TypeApi
        /// </summary>
        public static BitmovinApiBuilder<TypeApi> Builder => new BitmovinApiBuilder<TypeApi>();

        
        /// <summary>
        /// Get Manifest Type
        /// </summary>
        /// <param name="manifestId">UUID of the manifest</param>
        public async Task<Models.ManifestTypeResponse> GetAsync(string manifestId)
        {
            return await _apiClient.GetAsync(manifestId);
        }
        
        internal interface ITypeApiClient
        {
            
            [Get("/encoding/manifests/{manifest_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.ManifestTypeResponse> GetAsync([Path("manifest_id")] string manifestId);
            
        }
        
    }
}
