using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Vp8.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video.Vp8
{
    /// <summary>
    /// API for Vp8Api
    /// </summary>
    public class Vp8Api
    {
        private readonly IVp8ApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the Vp8Api class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public Vp8Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVp8ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Vp8Api
        /// </summary>
        public static BitmovinApiBuilder<Vp8Api> Builder => new BitmovinApiBuilder<Vp8Api>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create VP8 Codec Configuration
        /// </summary>
        /// <param name="vp8VideoConfiguration">The VP8 Codec Configuration to be created</param>
        public async Task<Models.Vp8VideoConfiguration> CreateAsync(Models.Vp8VideoConfiguration vp8VideoConfiguration)
        {
            return await _apiClient.CreateAsync(vp8VideoConfiguration);
        }

        /// <summary>
        /// Delete VP8 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// VP8 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.Vp8VideoConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Vp8VideoConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IVp8ApiClient
        {
            [Post("/encoding/configurations/video/vp8")]
            [AllowAnyStatusCode]
            Task<Models.Vp8VideoConfiguration> CreateAsync([Body] Models.Vp8VideoConfiguration vp8VideoConfiguration);

            [Delete("/encoding/configurations/video/vp8/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/vp8/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.Vp8VideoConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/vp8")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Vp8VideoConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
