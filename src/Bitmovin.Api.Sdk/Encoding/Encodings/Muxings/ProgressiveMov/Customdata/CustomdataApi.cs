using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveMov.Customdata
{
    /// <summary>
    /// API for CustomdataApi
    /// </summary>
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the CustomdataApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        /// <summary>
        /// Progressive MOV muxing Custom Data
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Progressive MOV muxing (required)</param>
        public async Task<Models.CustomData> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-mov/{muxing_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
        }
    }
}
