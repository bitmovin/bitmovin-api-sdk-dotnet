using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Passthrough
{
    /// <summary>
    /// API for PassthroughApi
    /// </summary>
    public class PassthroughApi
    {
        private readonly IPassthroughApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the PassthroughApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public PassthroughApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPassthroughApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of PassthroughApi
        /// </summary>
        public static BitmovinApiBuilder<PassthroughApi> Builder => new BitmovinApiBuilder<PassthroughApi>();

        /// <summary>
        /// Create Audio Passthrough Configuration
        /// </summary>
        /// <param name="passthroughAudioConfiguration">The Audio Passthrough Configuration to be created</param>
        public async Task<Models.PassthroughAudioConfiguration> CreateAsync(Models.PassthroughAudioConfiguration passthroughAudioConfiguration)
        {
            return await _apiClient.CreateAsync(passthroughAudioConfiguration);
        }

        /// <summary>
        /// Delete Audio Passthrough Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the audio configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// Audio Passthrough Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the audio configuration (required)</param>
        public async Task<Models.PassthroughAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List Audio Passthrough Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PassthroughAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IPassthroughApiClient
        {
            [Post("/encoding/configurations/audio/passthrough")]
            [AllowAnyStatusCode]
            Task<Models.PassthroughAudioConfiguration> CreateAsync([Body] Models.PassthroughAudioConfiguration passthroughAudioConfiguration);

            [Delete("/encoding/configurations/audio/passthrough/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/passthrough/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.PassthroughAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/passthrough")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PassthroughAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
