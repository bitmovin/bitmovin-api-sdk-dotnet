using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyAtmos.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyAtmos
{
    public class DolbyAtmosApi
    {
        private readonly IDolbyAtmosApiClient _apiClient;

        public DolbyAtmosApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDolbyAtmosApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DolbyAtmosApi
        /// </summary>
        public static BitmovinApiBuilder<DolbyAtmosApi> Builder => new BitmovinApiBuilder<DolbyAtmosApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Dolby Atmos Configuration
        /// </summary>
        /// <param name="dolbyAtmosAudioConfiguration">The Dolby Atmos Codec Configuration to be created</param>
        public async Task<Models.DolbyAtmosAudioConfiguration> CreateAsync(Models.DolbyAtmosAudioConfiguration dolbyAtmosAudioConfiguration)
        {
            return await _apiClient.CreateAsync(dolbyAtmosAudioConfiguration);
        }

        /// <summary>
        /// Delete Dolby Atmos Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// Dolby Atmos Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.DolbyAtmosAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List Dolby Atmos Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DolbyAtmosAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDolbyAtmosApiClient
        {
            [Post("/encoding/configurations/audio/dolby-atmos")]
            [AllowAnyStatusCode]
            Task<Models.DolbyAtmosAudioConfiguration> CreateAsync([Body] Models.DolbyAtmosAudioConfiguration dolbyAtmosAudioConfiguration);

            [Delete("/encoding/configurations/audio/dolby-atmos/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dolby-atmos/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.DolbyAtmosAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dolby-atmos")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DolbyAtmosAudioConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            /// <summary>
            /// Filter configuration by name
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

            private ListQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}
