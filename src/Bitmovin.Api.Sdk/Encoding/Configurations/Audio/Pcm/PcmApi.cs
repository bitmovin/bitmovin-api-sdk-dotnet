using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Pcm.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Pcm
{
    /// <summary>
    /// API for PcmApi
    /// </summary>
    public class PcmApi
    {
        private readonly IPcmApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the PcmApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public PcmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPcmApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of PcmApi
        /// </summary>
        public static BitmovinApiBuilder<PcmApi> Builder => new BitmovinApiBuilder<PcmApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create PCM Codec Configuration
        /// </summary>
        /// <param name="pcmAudioConfiguration">The PCM Codec Configuration to be created</param>
        public async Task<Models.PcmAudioConfiguration> CreateAsync(Models.PcmAudioConfiguration pcmAudioConfiguration)
        {
            return await _apiClient.CreateAsync(pcmAudioConfiguration);
        }

        /// <summary>
        /// Delete PCM Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// PCM Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.PcmAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List PCM Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PcmAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IPcmApiClient
        {
            [Post("/encoding/configurations/audio/pcm")]
            [AllowAnyStatusCode]
            Task<Models.PcmAudioConfiguration> CreateAsync([Body] Models.PcmAudioConfiguration pcmAudioConfiguration);

            [Delete("/encoding/configurations/audio/pcm/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/pcm/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.PcmAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/pcm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PcmAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
