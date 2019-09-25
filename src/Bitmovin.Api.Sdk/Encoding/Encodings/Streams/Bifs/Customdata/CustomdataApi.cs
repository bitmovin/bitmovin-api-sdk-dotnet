using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Bifs.Customdata
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
        /// Bif Custom Data
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="bifId">Id of the Bif configuration.</param>
        public async Task<Models.CustomData> GetAsync(string encodingId, string streamId, string bifId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, bifId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/bifs/{bif_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("bif_id")] string bifId);
            
        }
        
    }
}
