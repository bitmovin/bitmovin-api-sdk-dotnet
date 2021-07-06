using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyDigital.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DolbyDigital
{
    public class DolbyDigitalApi
    {
        private readonly IDolbyDigitalApiClient _apiClient;

        public DolbyDigitalApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDolbyDigitalApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DolbyDigitalApi
        /// </summary>
        public static BitmovinApiBuilder<DolbyDigitalApi> Builder => new BitmovinApiBuilder<DolbyDigitalApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Dolby Digital Codec Configuration
        /// </summary>
        /// <param name="dolbyDigitalAudioConfiguration">The Dolby Digital Codec Configuration to be created (Dolby Encoder v3.17)</param>
        public async Task<Models.DolbyDigitalAudioConfiguration> CreateAsync(Models.DolbyDigitalAudioConfiguration dolbyDigitalAudioConfiguration)
        {
            return await _apiClient.CreateAsync(dolbyDigitalAudioConfiguration);
        }

        /// <summary>
        /// Delete Dolby Digital Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// Dolby Digital Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.DolbyDigitalAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List Dolby Digital Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DolbyDigitalAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDolbyDigitalApiClient
        {
            [Post("/encoding/configurations/audio/dolby-digital")]
            [AllowAnyStatusCode]
            Task<Models.DolbyDigitalAudioConfiguration> CreateAsync([Body] Models.DolbyDigitalAudioConfiguration dolbyDigitalAudioConfiguration);

            [Delete("/encoding/configurations/audio/dolby-digital/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dolby-digital/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.DolbyDigitalAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dolby-digital")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DolbyDigitalAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
