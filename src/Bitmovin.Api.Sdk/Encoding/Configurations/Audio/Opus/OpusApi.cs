using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Opus.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Opus
{
    public class OpusApi
    {
        private readonly IOpusApiClient _apiClient;

        public OpusApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IOpusApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OpusApi
        /// </summary>
        public static BitmovinApiBuilder<OpusApi> Builder => new BitmovinApiBuilder<OpusApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create Opus Codec Configuration
        /// </summary>
        /// <param name="opusAudioConfiguration">The request payload</param>
        public async Task<Models.OpusAudioConfiguration> CreateAsync(Models.OpusAudioConfiguration opusAudioConfiguration)
        {
            return await _apiClient.CreateAsync(opusAudioConfiguration);
        }
        
        /// <summary>
        /// Delete Opus Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }
        
        /// <summary>
        /// Opus Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.OpusAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        /// <summary>
        /// List Opus Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.OpusAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IOpusApiClient
        {
            
            [Post("/encoding/configurations/audio/opus")]
            [AllowAnyStatusCode]
            Task<Models.OpusAudioConfiguration> CreateAsync([Body] Models.OpusAudioConfiguration opusAudioConfiguration);
            
            [Delete("/encoding/configurations/audio/opus/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/audio/opus/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.OpusAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/audio/opus")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.OpusAudioConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
