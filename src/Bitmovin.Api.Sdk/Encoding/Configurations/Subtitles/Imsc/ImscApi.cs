using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.Imsc.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.Imsc
{
    /// <summary>
    /// API for ImscApi
    /// </summary>
    public class ImscApi
    {
        private readonly IImscApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ImscApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ImscApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IImscApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ImscApi
        /// </summary>
        public static BitmovinApiBuilder<ImscApi> Builder => new BitmovinApiBuilder<ImscApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create IMSC subtitle configuration
        /// </summary>
        /// <param name="imscConfiguration">The IMSC subtitle configuration to be created</param>
        public async Task<Models.ImscConfiguration> CreateAsync(Models.ImscConfiguration imscConfiguration)
        {
            return await _apiClient.CreateAsync(imscConfiguration);
        }

        /// <summary>
        /// Delete IMSC subtitle configuration
        /// </summary>
        /// <param name="configurationId">Id of the subtitle configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// IMSC subtitle configuration details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.ImscConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List IMSC subtitle configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ImscConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IImscApiClient
        {
            [Post("/encoding/configurations/subtitles/imsc")]
            [AllowAnyStatusCode]
            Task<Models.ImscConfiguration> CreateAsync([Body] Models.ImscConfiguration imscConfiguration);

            [Delete("/encoding/configurations/subtitles/imsc/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/subtitles/imsc/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.ImscConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/subtitles/imsc")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ImscConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
