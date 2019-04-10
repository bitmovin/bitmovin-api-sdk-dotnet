using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Captions.Webvtt.Customdata
{
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        
        /// <summary>
        /// Get CMAF Embed WebVtt Captions Custom Data
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the CMAF muxing</param>
        /// <param name="captionsId">Id of the captions config.</param>
        public async Task<Models.CustomData> GetCustomDataAsync(string encodingId, string muxingId, string captionsId)
        {
            return await _apiClient.GetCustomDataAsync(encodingId, muxingId, captionsId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}/captions/webvtt/{captions_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("captions_id")] string captionsId);
            
        }
        
    }
}
