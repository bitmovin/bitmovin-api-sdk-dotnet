using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Dvbsub.Customdata
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
        /// Get Burn-In DVB-SUB Subtitle Custom Data
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="subtitleId">Id of the subtitle.</param>
        public async Task<Models.CustomData> GetCustomDataAsync(string encodingId, string streamId, string subtitleId)
        {
            return await _apiClient.GetCustomDataAsync(encodingId, streamId, subtitleId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/dvbsub/{subtitle_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("subtitle_id")] string subtitleId);
            
        }
        
    }
}
