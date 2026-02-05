using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DtsPassthrough.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.DtsPassthrough
{
    /// <summary>
    /// API for DtsPassthroughApi
    /// </summary>
    public class DtsPassthroughApi
    {
        private readonly IDtsPassthroughApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DtsPassthroughApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DtsPassthroughApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDtsPassthroughApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DtsPassthroughApi
        /// </summary>
        public static BitmovinApiBuilder<DtsPassthroughApi> Builder => new BitmovinApiBuilder<DtsPassthroughApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create DTS Passthrough Configuration
        /// </summary>
        /// <param name="dtsPassthroughAudioConfiguration">The DTS Passthrough Codec Configuration to be created</param>
        public async Task<Models.DtsPassthroughAudioConfiguration> CreateAsync(Models.DtsPassthroughAudioConfiguration dtsPassthroughAudioConfiguration)
        {
            return await _apiClient.CreateAsync(dtsPassthroughAudioConfiguration);
        }

        /// <summary>
        /// Delete DTS Passthrough Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// DTS Passthrough Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.DtsPassthroughAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List DTS Passthrough Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DtsPassthroughAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDtsPassthroughApiClient
        {
            [Post("/encoding/configurations/audio/dts-passthrough")]
            [AllowAnyStatusCode]
            Task<Models.DtsPassthroughAudioConfiguration> CreateAsync([Body] Models.DtsPassthroughAudioConfiguration dtsPassthroughAudioConfiguration);

            [Delete("/encoding/configurations/audio/dts-passthrough/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dts-passthrough/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.DtsPassthroughAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dts-passthrough")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DtsPassthroughAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
