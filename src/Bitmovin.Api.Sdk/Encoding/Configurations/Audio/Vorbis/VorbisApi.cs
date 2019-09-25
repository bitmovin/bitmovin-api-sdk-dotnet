using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Vorbis.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Vorbis
{
    public class VorbisApi
    {
        private readonly IVorbisApiClient _apiClient;

        public VorbisApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVorbisApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of VorbisApi
        /// </summary>
        public static BitmovinApiBuilder<VorbisApi> Builder => new BitmovinApiBuilder<VorbisApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Vorbis Codec Configuration
        /// </summary>
        /// <param name="vorbisAudioConfiguration">The request payload</param>
        public async Task<Models.VorbisAudioConfiguration> CreateAsync(Models.VorbisAudioConfiguration vorbisAudioConfiguration)
        {
            return await _apiClient.CreateAsync(vorbisAudioConfiguration);
        }
        
        /// <summary>
        /// Delete Vorbis Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }
        
        /// <summary>
        /// Vorbis Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
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
            Task<Models.PaginationResponse<Models.VorbisAudioConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

            /// <summary>
            /// Filter configuration by name
            /// </summary>
            public ListQueryParams Name(string Name) => SetQueryParam("name", Name);

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
