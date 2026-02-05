using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Local.Customdata
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
        /// Local Input Custom Data
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.CustomData> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/inputs/local/{input_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("input_id")] string inputId);
        }
    }
}
