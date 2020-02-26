using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.Local.Customdata
{
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        /// <summary>
        /// Local Output Custom Data
        /// </summary>
        /// <param name="outputId">Id of the Output (required)</param>
        public async Task<Models.CustomData> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/outputs/local/{output_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("output_id")] string outputId);
        }
    }
}
