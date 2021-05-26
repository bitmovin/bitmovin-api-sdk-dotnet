using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Outputs.Azure.Customdata
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
        /// Azure Output Custom Data
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.CustomData> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/analytics/outputs/azure/{output_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("output_id")] string outputId);
        }
    }
}
