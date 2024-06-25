using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWav.Information
{
    public class InformationApi
    {
        private readonly IInformationApiClient _apiClient;

        public InformationApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInformationApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of InformationApi
        /// </summary>
        public static BitmovinApiBuilder<InformationApi> Builder => new BitmovinApiBuilder<InformationApi>();

        /// <summary>
        /// Progressive WAV muxing Information
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Progressive WAV muxing (required)</param>
        public async Task<Models.ProgressiveWavMuxingInformation> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        internal interface IInformationApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-wav/{muxing_id}/information")]
            [AllowAnyStatusCode]
            Task<Models.ProgressiveWavMuxingInformation> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
        }
    }
}
