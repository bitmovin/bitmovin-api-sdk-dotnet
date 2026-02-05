using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Type
{
    /// <summary>
    /// API for TypeApi
    /// </summary>
    public class TypeApi
    {
        private readonly ITypeApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the TypeApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public TypeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITypeApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TypeApi
        /// </summary>
        public static BitmovinApiBuilder<TypeApi> Builder => new BitmovinApiBuilder<TypeApi>();

        /// <summary>
        /// Get Muxing type
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the muxing. (required)</param>
        public async Task<Models.MuxingTypeResponse> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        internal interface ITypeApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/muxings/{muxing_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.MuxingTypeResponse> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
        }
    }
}
