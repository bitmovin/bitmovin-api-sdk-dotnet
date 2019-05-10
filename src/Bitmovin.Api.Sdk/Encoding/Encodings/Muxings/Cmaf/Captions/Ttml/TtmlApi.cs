using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Captions.Ttml
{
    public class TtmlApi
    {
        private readonly ITtmlApiClient _apiClient;

        public TtmlApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITtmlApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of TtmlApi
        /// </summary>
        public static BitmovinApiBuilder<TtmlApi> Builder => new BitmovinApiBuilder<TtmlApi>();

        
        /// <summary>
        /// Delete TTML Embed Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the CMAF muxing</param>
        /// <param name="captionsId">Id of the captions configuration.</param>
        public async Task<Models.TtmlEmbed> DeleteAsync(string encodingId, string muxingId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, captionsId);
        }
        
        /// <summary>
        /// TTML Embed Captions Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the CMAF muxing</param>
        /// <param name="captionsId">Id of the captions.</param>
        public async Task<Models.TtmlEmbed> GetAsync(string encodingId, string muxingId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, captionsId);
        }
        
        internal interface ITtmlApiClient
        {
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}/captions/ttml/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.TtmlEmbed> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}/captions/ttml/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.TtmlEmbed> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("captions_id")] string captionsId);
            
        }
        
    }
}
