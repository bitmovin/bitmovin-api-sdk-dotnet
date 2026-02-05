using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyDigitalPlus.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyDigitalPlus
{
    /// <summary>
    /// API for DolbyDigitalPlusApi
    /// </summary>
    public class DolbyDigitalPlusApi
    {
        private readonly IDolbyDigitalPlusApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DolbyDigitalPlusApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DolbyDigitalPlusApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDolbyDigitalPlusApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DolbyDigitalPlusApi
        /// </summary>
        public static BitmovinApiBuilder<DolbyDigitalPlusApi> Builder => new BitmovinApiBuilder<DolbyDigitalPlusApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Dolby Digital Plus Codec Configuration
        /// </summary>
        /// <param name="dolbyDigitalPlusAudioConfiguration">The Dolby Digital Plus Codec Configuration to be created (Dolby Encoder v3.17).  Dolby Digital Plus enables high-resolution multichannel audio at lower bit rates than with Dolby Digital. </param>
        public async Task<Models.DolbyDigitalPlusAudioConfiguration> CreateAsync(Models.DolbyDigitalPlusAudioConfiguration dolbyDigitalPlusAudioConfiguration)
        {
            return await _apiClient.CreateAsync(dolbyDigitalPlusAudioConfiguration);
        }

        /// <summary>
        /// Delete Dolby Digital Plus Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// Dolby Digital Plus Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.DolbyDigitalPlusAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List Dolby Digital Plus Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DolbyDigitalPlusAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDolbyDigitalPlusApiClient
        {
            [Post("/encoding/configurations/audio/dolby-digital-plus")]
            [AllowAnyStatusCode]
            Task<Models.DolbyDigitalPlusAudioConfiguration> CreateAsync([Body] Models.DolbyDigitalPlusAudioConfiguration dolbyDigitalPlusAudioConfiguration);

            [Delete("/encoding/configurations/audio/dolby-digital-plus/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dolby-digital-plus/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.DolbyDigitalPlusAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dolby-digital-plus")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DolbyDigitalPlusAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
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
