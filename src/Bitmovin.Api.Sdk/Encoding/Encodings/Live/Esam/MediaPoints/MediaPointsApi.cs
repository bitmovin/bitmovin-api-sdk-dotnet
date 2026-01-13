using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.Esam.MediaPoints
{
    public class MediaPointsApi
    {
        private readonly IMediaPointsApiClient _apiClient;

        public MediaPointsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMediaPointsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of MediaPointsApi
        /// </summary>
        public static BitmovinApiBuilder<MediaPointsApi> Builder => new BitmovinApiBuilder<MediaPointsApi>();

        /// <summary>
        /// Create ESAM media point for live stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="esamMediaPoint">ESAM media point</param>
        public async Task<Models.EsamMediaPoint> CreateAsync(string encodingId, Models.EsamMediaPoint esamMediaPoint)
        {
            return await _apiClient.CreateAsync(encodingId, esamMediaPoint);
        }

        internal interface IMediaPointsApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/live/esam/media-points")]
            [AllowAnyStatusCode]
            Task<Models.EsamMediaPoint> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.EsamMediaPoint esamMediaPoint);
        }
    }
}
