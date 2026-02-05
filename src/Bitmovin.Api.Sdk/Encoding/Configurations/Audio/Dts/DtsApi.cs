using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Dts.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Dts
{
    /// <summary>
    /// API for DtsApi
    /// </summary>
    public class DtsApi
    {
        private readonly IDtsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DtsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DtsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDtsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DtsApi
        /// </summary>
        public static BitmovinApiBuilder<DtsApi> Builder => new BitmovinApiBuilder<DtsApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create DTS Codec Configuration
        /// </summary>
        /// <param name="dtsAudioConfiguration">The DTS Codec Configuration to be created</param>
        public async Task<Models.DtsAudioConfiguration> CreateAsync(Models.DtsAudioConfiguration dtsAudioConfiguration)
        {
            return await _apiClient.CreateAsync(dtsAudioConfiguration);
        }

        /// <summary>
        /// Delete DTS Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// DTS Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.DtsAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List DTS Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DtsAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDtsApiClient
        {
            [Post("/encoding/configurations/audio/dts")]
            [AllowAnyStatusCode]
            Task<Models.DtsAudioConfiguration> CreateAsync([Body] Models.DtsAudioConfiguration dtsAudioConfiguration);

            [Delete("/encoding/configurations/audio/dts/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dts/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.DtsAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dts")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DtsAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
