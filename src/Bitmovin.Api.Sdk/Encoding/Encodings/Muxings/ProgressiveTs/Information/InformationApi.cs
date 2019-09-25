using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Information
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
        /// Progressive TS Muxing Information
        /// </summary>
        /// <param name="encodingId">ID of the Encoding.</param>
        /// <param name="muxingId">ID of the Progressive TS Muxing</param>
        public async Task<Models.ProgressiveTsMuxingInformation> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        internal interface IInformationApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/information")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveTsMuxingInformation> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
        }
        
    }
}
