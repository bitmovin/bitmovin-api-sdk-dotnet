using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Type
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
        /// HLS Media Type
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="mediaId">Id of the video media.</param>
        public async Task<Models.MediaInfoTypeResponse> GetAsync(string manifestId, string mediaId)
        {
            return await _apiClient.GetAsync(manifestId, mediaId);
        }
        
        internal interface ITypeApiClient
        {
            
            [Get("/encoding/manifests/hls/{manifest_id}/media/{media_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.MediaInfoTypeResponse> GetAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);
            
        }
        
    }
}
