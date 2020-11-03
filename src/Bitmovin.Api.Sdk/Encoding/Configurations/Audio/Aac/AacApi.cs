using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Aac.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Aac
{
    public class AacApi
    {
        private readonly IAacApiClient _apiClient;

        public AacApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAacApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AacApi
        /// </summary>
        public static BitmovinApiBuilder<AacApi> Builder => new BitmovinApiBuilder<AacApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create AAC Codec Configuration
        /// </summary>
        /// <param name="aacAudioConfiguration">The AAC Codec Configuration to be created</param>
        public async Task<Models.AacAudioConfiguration> CreateAsync(Models.AacAudioConfiguration aacAudioConfiguration)
        {
            return await _apiClient.CreateAsync(aacAudioConfiguration);
        }

        /// <summary>
        /// Delete AAC Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// AAC Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.AacAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List AAC Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AacAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAacApiClient
        {
            [Post("/encoding/configurations/audio/aac")]
            [AllowAnyStatusCode]
            Task<Models.AacAudioConfiguration> CreateAsync([Body] Models.AacAudioConfiguration aacAudioConfiguration);

            [Delete("/encoding/configurations/audio/aac/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/aac/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.AacAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/aac")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AacAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
