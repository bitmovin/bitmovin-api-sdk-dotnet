using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp2.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp2
{
    /// <summary>
    /// API for Mp2Api
    /// </summary>
    public class Mp2Api
    {
        private readonly IMp2ApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the Mp2Api class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public Mp2Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMp2ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Mp2Api
        /// </summary>
        public static BitmovinApiBuilder<Mp2Api> Builder => new BitmovinApiBuilder<Mp2Api>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create MP2 Codec Configuration
        /// </summary>
        /// <param name="mp2AudioConfiguration">The MP2 Codec Configuration to be created</param>
        public async Task<Models.Mp2AudioConfiguration> CreateAsync(Models.Mp2AudioConfiguration mp2AudioConfiguration)
        {
            return await _apiClient.CreateAsync(mp2AudioConfiguration);
        }

        /// <summary>
        /// Delete MP2 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// MP2 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.Mp2AudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List MP2 Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Mp2AudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IMp2ApiClient
        {
            [Post("/encoding/configurations/audio/mp2")]
            [AllowAnyStatusCode]
            Task<Models.Mp2AudioConfiguration> CreateAsync([Body] Models.Mp2AudioConfiguration mp2AudioConfiguration);

            [Delete("/encoding/configurations/audio/mp2/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/mp2/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.Mp2AudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/mp2")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Mp2AudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
