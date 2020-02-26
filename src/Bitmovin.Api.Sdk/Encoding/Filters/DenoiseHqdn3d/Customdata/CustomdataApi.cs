using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Filters.DenoiseHqdn3d.Customdata
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
        /// Denoise hqdn3d Filter Custom Data
        /// </summary>
        /// <param name="filterId">Id of the denoise hqdn3d filter (required)</param>
        public async Task<Models.CustomData> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/filters/denoise-hqdn3d/{filter_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("filter_id")] string filterId);
        }
    }
}
