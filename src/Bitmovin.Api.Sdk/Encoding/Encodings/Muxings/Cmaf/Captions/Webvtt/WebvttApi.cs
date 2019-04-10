using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Captions.Webvtt.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Captions.Webvtt
{
    public class WebvttApi
    {
        private readonly IWebvttApiClient _apiClient;

        public WebvttApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWebvttApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WebvttApi
        /// </summary>
        public static BitmovinApiBuilder<WebvttApi> Builder => new BitmovinApiBuilder<WebvttApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// CMAF Embed WebVtt Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the CMAF muxing</param>
        /// <param name="webVttEmbed">The request payload</param>
        public async Task<Models.WebVttEmbed> CreateAsync(string encodingId, string muxingId, Models.WebVttEmbed webVttEmbed)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, webVttEmbed);
        }
        
        /// <summary>
        /// Get CMAF Embed WebVtt Captions Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the CMAF muxing</param>
        /// <param name="captionsId">Id of the captions config.</param>
        public async Task<Models.WebVttEmbed> GetAsync(string encodingId, string muxingId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, captionsId);
        }
        
        /// <summary>
        /// List CMAF Embed WebVtt Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the CMAF muxing</param>
        public async Task<Models.PaginationResponse<Models.WebVttEmbed>> ListAsync(string encodingId, string muxingId)
        {
            return await _apiClient.ListAsync(encodingId, muxingId);
        }
        
        internal interface IWebvttApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}/captions/webvtt")]
            [AllowAnyStatusCode]
            Task<Models.WebVttEmbed> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.WebVttEmbed webVttEmbed);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}/captions/webvtt/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebVttEmbed> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}/captions/webvtt")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.WebVttEmbed>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
        }
        
    }
}
