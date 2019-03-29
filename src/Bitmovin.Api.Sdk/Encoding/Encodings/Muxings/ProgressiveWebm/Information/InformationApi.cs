using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm.Information
{
    public class InformationApi
    {
        private readonly IInformationApiClient _apiClient;

        public InformationApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInformationApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of InformationApi
        /// </summary>
        public static BitmovinApiBuilder<InformationApi> Builder => new BitmovinApiBuilder<InformationApi>();

        
        /// <summary>
        /// Progressive WebM Muxing Information
        /// </summary>
        /// <param name="encodingId">ID of the Encoding.</param>
        /// <param name="muxingId">ID of the Progressive WebM muxing</param>
        public async Task<Models.ProgressiveWebmMuxingInformation> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        internal interface IInformationApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-webm/{muxing_id}/information")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveWebmMuxingInformation> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
        }
        
    }
}
