using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars.Customdata
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
        /// Sidecar Custom Data
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="sidecarId">Id of the sidecar. (required)</param>
        public async Task<Models.CustomData> GetAsync(string encodingId, string sidecarId)
        {
            return await _apiClient.GetAsync(encodingId, sidecarId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/sidecars/{sidecar_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);
        }
    }
}
