using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Av1.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video.Av1
{
    /// <summary>
    /// API for Av1Api
    /// </summary>
    public class Av1Api
    {
        private readonly IAv1ApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the Av1Api class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public Av1Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAv1ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Av1Api
        /// </summary>
        public static BitmovinApiBuilder<Av1Api> Builder => new BitmovinApiBuilder<Av1Api>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create AV1 Codec Configuration
        /// </summary>
        /// <param name="av1VideoConfiguration">The AV1 Codec Configuration to be created</param>
        public async Task<Models.Av1VideoConfiguration> CreateAsync(Models.Av1VideoConfiguration av1VideoConfiguration)
        {
            return await _apiClient.CreateAsync(av1VideoConfiguration);
        }

        /// <summary>
        /// Delete AV1 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// AV1 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.Av1VideoConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List AV1 Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Av1VideoConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAv1ApiClient
        {
            [Post("/encoding/configurations/video/av1")]
            [AllowAnyStatusCode]
            Task<Models.Av1VideoConfiguration> CreateAsync([Body] Models.Av1VideoConfiguration av1VideoConfiguration);

            [Delete("/encoding/configurations/video/av1/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/av1/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.Av1VideoConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/av1")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Av1VideoConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
