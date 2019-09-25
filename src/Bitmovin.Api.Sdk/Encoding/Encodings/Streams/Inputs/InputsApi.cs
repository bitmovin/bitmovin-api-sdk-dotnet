using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Inputs
{
    public class InputsApi
    {
        private readonly IInputsApiClient _apiClient;

        public InputsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInputsApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of InputsApi
        /// </summary>
        public static BitmovinApiBuilder<InputsApi> Builder => new BitmovinApiBuilder<InputsApi>();

        
        /// <summary>
        /// Stream Input Analysis Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        public async Task<Models.PaginationResponse<Models.StreamDetails>> ListAsync(string encodingId, string streamId)
        {
            return await _apiClient.ListAsync(encodingId, streamId);
        }
        
        internal interface IInputsApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/inputs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StreamDetails>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId);
            
        }
        
    }
}
