using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Type
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
        /// Get Input Stream Type
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="inputStreamId">Id of the input stream</param>
        public async Task<Models.InputStreamTypeResponse> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }
        
        internal interface ITypeApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/input-streams/{input_stream_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.InputStreamTypeResponse> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);
            
        }
        
    }
}
