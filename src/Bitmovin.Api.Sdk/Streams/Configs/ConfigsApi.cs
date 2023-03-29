using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.Configs
{
    public class ConfigsApi
    {
        private readonly IConfigsApiClient _apiClient;

        public ConfigsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IConfigsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ConfigsApi
        /// </summary>
        public static BitmovinApiBuilder<ConfigsApi> Builder => new BitmovinApiBuilder<ConfigsApi>();

        /// <summary>
        /// Update stream config by id
        /// </summary>
        /// <param name="configId">Id of the stream config. (required)</param>
        /// <param name="streamsConfigUpdateRequest">The updated stream config object.</param>
        public async Task<Models.StreamsConfigResponse> PatchStreamConfigAsync(string configId, Models.StreamsConfigUpdateRequest streamsConfigUpdateRequest)
        {
            return await _apiClient.PatchStreamConfigAsync(configId, streamsConfigUpdateRequest);
        }

        internal interface IConfigsApiClient
        {
            [Patch("/streams/configs/{config_id}")]
            [AllowAnyStatusCode]
            Task<Models.StreamsConfigResponse> PatchStreamConfigAsync([Path("config_id")] string configId, [Body] Models.StreamsConfigUpdateRequest streamsConfigUpdateRequest);
        }
    }
}
