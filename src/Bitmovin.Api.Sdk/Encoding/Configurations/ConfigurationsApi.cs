using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Type;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles;

namespace Bitmovin.Api.Sdk.Encoding.Configurations
{
    /// <summary>
    /// API for ConfigurationsApi
    /// </summary>
    public class ConfigurationsApi
    {
        private readonly IConfigurationsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ConfigurationsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ConfigurationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IConfigurationsApiClient>();
            Type = new TypeApi(apiClientFactory);
            Video = new VideoApi(apiClientFactory);
            Audio = new AudioApi(apiClientFactory);
            Subtitles = new SubtitlesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ConfigurationsApi
        /// </summary>
        public static BitmovinApiBuilder<ConfigurationsApi> Builder => new BitmovinApiBuilder<ConfigurationsApi>();

        /// <summary>
        /// Gets the Type API
        /// </summary>
        public TypeApi Type { get; }
        /// <summary>
        /// Gets the Video API
        /// </summary>
        public VideoApi Video { get; }
        /// <summary>
        /// Gets the Audio API
        /// </summary>
        public AudioApi Audio { get; }
        /// <summary>
        /// Gets the Subtitles API
        /// </summary>
        public SubtitlesApi Subtitles { get; }

        /// <summary>
        /// Get Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.CodecConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List all Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CodecConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IConfigurationsApiClient
        {
            [Get("/encoding/configurations/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.CodecConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CodecConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

            /// <summary>
            /// Order list result according to a filter resource attribute. The fields that can be used for sorting are: + &#x60;id&#x60; + &#x60;createdAt&#x60; + &#x60;modifiedAt&#x60; + &#x60;type&#x60; + &#x60;name&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

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
