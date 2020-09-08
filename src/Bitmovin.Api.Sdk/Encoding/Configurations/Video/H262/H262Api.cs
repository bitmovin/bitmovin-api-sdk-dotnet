using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H262.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video.H262
{
    public class H262Api
    {
        private readonly IH262ApiClient _apiClient;

        public H262Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IH262ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of H262Api
        /// </summary>
        public static BitmovinApiBuilder<H262Api> Builder => new BitmovinApiBuilder<H262Api>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create H262 Codec Configuration
        /// </summary>
        /// <param name="h262VideoConfiguration">The H262 Codec Configuration to be created</param>
        public async Task<Models.H262VideoConfiguration> CreateAsync(Models.H262VideoConfiguration h262VideoConfiguration)
        {
            return await _apiClient.CreateAsync(h262VideoConfiguration);
        }

        /// <summary>
        /// Delete H262 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// H262 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.H262VideoConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List H262 Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.H262VideoConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IH262ApiClient
        {
            [Post("/encoding/configurations/video/h262")]
            [AllowAnyStatusCode]
            Task<Models.H262VideoConfiguration> CreateAsync([Body] Models.H262VideoConfiguration h262VideoConfiguration);

            [Delete("/encoding/configurations/video/h262/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/h262/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.H262VideoConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/h262")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.H262VideoConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
        }

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
