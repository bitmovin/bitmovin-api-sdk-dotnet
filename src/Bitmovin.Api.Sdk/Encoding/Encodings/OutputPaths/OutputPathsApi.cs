using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.OutputPaths
{
    public class OutputPathsApi
    {
        private readonly IOutputPathsApiClient _apiClient;

        public OutputPathsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IOutputPathsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of OutputPathsApi
        /// </summary>
        public static BitmovinApiBuilder<OutputPathsApi> Builder => new BitmovinApiBuilder<OutputPathsApi>();

        /// <summary>
        /// Encoding Output Paths Retrieval
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        public async Task<List<Models.EncodingOutputPaths>> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        internal interface IOutputPathsApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/output-paths")]
            [AllowAnyStatusCode]
            Task<List<Models.EncodingOutputPaths>> GetAsync([Path("encoding_id")] string encodingId);
        }
    }
}
