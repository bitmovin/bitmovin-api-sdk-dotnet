using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV1.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV1
{
    /// <summary>
    /// API for HeAacV1Api
    /// </summary>
    public class HeAacV1Api
    {
        private readonly IHeAacV1ApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the HeAacV1Api class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public HeAacV1Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IHeAacV1ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of HeAacV1Api
        /// </summary>
        public static BitmovinApiBuilder<HeAacV1Api> Builder => new BitmovinApiBuilder<HeAacV1Api>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create HE-AAC v1 Codec Configuration
        /// </summary>
        /// <param name="heAacV1AudioConfiguration">The HE-AAC Codec Configuration to be created</param>
        public async Task<Models.HeAacV1AudioConfiguration> CreateAsync(Models.HeAacV1AudioConfiguration heAacV1AudioConfiguration)
        {
            return await _apiClient.CreateAsync(heAacV1AudioConfiguration);
        }

        /// <summary>
        /// Delete HE-AAC v1 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// HE-AAC v1 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.HeAacV1AudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List HE-AAC v1 Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.HeAacV1AudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IHeAacV1ApiClient
        {
            [Post("/encoding/configurations/audio/he-aac-v1")]
            [AllowAnyStatusCode]
            Task<Models.HeAacV1AudioConfiguration> CreateAsync([Body] Models.HeAacV1AudioConfiguration heAacV1AudioConfiguration);

            [Delete("/encoding/configurations/audio/he-aac-v1/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/he-aac-v1/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.HeAacV1AudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/he-aac-v1")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.HeAacV1AudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
