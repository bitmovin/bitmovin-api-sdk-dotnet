using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Filters.AzureSpeechToCaptions.Customdata
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
        /// Azure Speech to captions Filter Custom Data
        /// </summary>
        /// <param name="filterId">Id of the Azure Speech to captions Filter. (required)</param>
        public async Task<Models.CustomData> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/filters/azure-speech-to-captions/{filter_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("filter_id")] string filterId);
        }
    }
}
