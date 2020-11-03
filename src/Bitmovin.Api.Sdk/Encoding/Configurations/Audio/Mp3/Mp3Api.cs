using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp3.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp3
{
    public class Mp3Api
    {
        private readonly IMp3ApiClient _apiClient;

        public Mp3Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMp3ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Mp3Api
        /// </summary>
        public static BitmovinApiBuilder<Mp3Api> Builder => new BitmovinApiBuilder<Mp3Api>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create MP3 Codec Configuration
        /// </summary>
        /// <param name="mp3AudioConfiguration">The MP3 Codec Configuration to be created</param>
        public async Task<Models.Mp3AudioConfiguration> CreateAsync(Models.Mp3AudioConfiguration mp3AudioConfiguration)
        {
            return await _apiClient.CreateAsync(mp3AudioConfiguration);
        }

        /// <summary>
        /// Delete MP3 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// MP3 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.Mp3AudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List MP3 Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Mp3AudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IMp3ApiClient
        {
            [Post("/encoding/configurations/audio/mp3")]
            [AllowAnyStatusCode]
            Task<Models.Mp3AudioConfiguration> CreateAsync([Body] Models.Mp3AudioConfiguration mp3AudioConfiguration);

            [Delete("/encoding/configurations/audio/mp3/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/mp3/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.Mp3AudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/mp3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Mp3AudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
