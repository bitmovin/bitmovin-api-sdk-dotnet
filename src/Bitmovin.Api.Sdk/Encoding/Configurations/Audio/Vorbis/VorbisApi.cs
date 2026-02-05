using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Vorbis.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Vorbis
{
    /// <summary>
    /// API for VorbisApi
    /// </summary>
    public class VorbisApi
    {
        private readonly IVorbisApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the VorbisApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public VorbisApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVorbisApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of VorbisApi
        /// </summary>
        public static BitmovinApiBuilder<VorbisApi> Builder => new BitmovinApiBuilder<VorbisApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Vorbis Codec Configuration
        /// </summary>
        /// <param name="vorbisAudioConfiguration">The Vorbis Codec Configuration to be created</param>
        public async Task<Models.VorbisAudioConfiguration> CreateAsync(Models.VorbisAudioConfiguration vorbisAudioConfiguration)
        {
            return await _apiClient.CreateAsync(vorbisAudioConfiguration);
        }

        /// <summary>
        /// Delete Vorbis Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// Vorbis Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.VorbisAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List Vorbis Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.VorbisAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IVorbisApiClient
        {
            [Post("/encoding/configurations/audio/vorbis")]
            [AllowAnyStatusCode]
            Task<Models.VorbisAudioConfiguration> CreateAsync([Body] Models.VorbisAudioConfiguration vorbisAudioConfiguration);

            [Delete("/encoding/configurations/audio/vorbis/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/vorbis/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.VorbisAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/vorbis")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.VorbisAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
