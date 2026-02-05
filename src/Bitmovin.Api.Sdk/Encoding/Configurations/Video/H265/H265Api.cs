using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H265.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video.H265
{
    /// <summary>
    /// API for H265Api
    /// </summary>
    public class H265Api
    {
        private readonly IH265ApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the H265Api class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public H265Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IH265ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of H265Api
        /// </summary>
        public static BitmovinApiBuilder<H265Api> Builder => new BitmovinApiBuilder<H265Api>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create H265/HEVC Codec Configuration
        /// </summary>
        /// <param name="h265VideoConfiguration">The H265/HEVC Codec Configuration to be created</param>
        public async Task<Models.H265VideoConfiguration> CreateAsync(Models.H265VideoConfiguration h265VideoConfiguration)
        {
            return await _apiClient.CreateAsync(h265VideoConfiguration);
        }

        /// <summary>
        /// Delete H265/HEVC Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// H265/HEVC Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.H265VideoConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List H265/HEVC Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.H265VideoConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IH265ApiClient
        {
            [Post("/encoding/configurations/video/h265")]
            [AllowAnyStatusCode]
            Task<Models.H265VideoConfiguration> CreateAsync([Body] Models.H265VideoConfiguration h265VideoConfiguration);

            [Delete("/encoding/configurations/video/h265/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/h265/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.H265VideoConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/h265")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.H265VideoConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
