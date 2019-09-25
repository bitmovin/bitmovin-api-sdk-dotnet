using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Dvbsub
{
    public class DvbsubApi
    {
        private readonly IDvbsubApiClient _apiClient;

        public DvbsubApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDvbsubApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of DvbsubApi
        /// </summary>
        public static BitmovinApiBuilder<DvbsubApi> Builder => new BitmovinApiBuilder<DvbsubApi>();

        
        /// <summary>
        /// Burn-In DVB-SUB Subtitle into Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="streamDvbSubSubtitle">The request payload</param>
        public async Task<Models.StreamDvbSubSubtitle> CreateAsync(string encodingId, string streamId, Models.StreamDvbSubSubtitle streamDvbSubSubtitle)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, streamDvbSubSubtitle);
        }
        
        internal interface IDvbsubApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/burn-in-subtitles/dvbsub")]
            [AllowAnyStatusCode]
            Task<Models.StreamDvbSubSubtitle> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.StreamDvbSubSubtitle streamDvbSubSubtitle);
            
        }
        
    }
}
