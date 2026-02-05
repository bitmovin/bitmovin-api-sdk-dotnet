using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveMov.Information
{
    /// <summary>
    /// API for InformationApi
    /// </summary>
    public class InformationApi
    {
        private readonly IInformationApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the InformationApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public InformationApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInformationApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of InformationApi
        /// </summary>
        public static BitmovinApiBuilder<InformationApi> Builder => new BitmovinApiBuilder<InformationApi>();

        /// <summary>
        /// Progressive MOV muxing Information
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Progressive MOV muxing (required)</param>
        public async Task<Models.ProgressiveMovMuxingInformation> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        internal interface IInformationApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-mov/{muxing_id}/information")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveMovMuxingInformation> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
        }
    }
}
