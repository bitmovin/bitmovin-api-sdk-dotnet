using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Eac3.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Eac3
{
    public class Eac3Api
    {
        private readonly IEac3ApiClient _apiClient;

        public Eac3Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEac3ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Eac3Api
        /// </summary>
        public static BitmovinApiBuilder<Eac3Api> Builder => new BitmovinApiBuilder<Eac3Api>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create E-AC3 Codec Configuration
        /// </summary>
        /// <param name="eac3AudioConfiguration">The E-AC3 Codec Configuration to be created</param>
        public async Task<Models.Eac3AudioConfiguration> CreateAsync(Models.Eac3AudioConfiguration eac3AudioConfiguration)
        {
            return await _apiClient.CreateAsync(eac3AudioConfiguration);
        }

        /// <summary>
        /// Delete E-AC3 Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// E-AC3 Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.Eac3AudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List E-AC3 Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Eac3AudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IEac3ApiClient
        {
            [Post("/encoding/configurations/audio/eac3")]
            [AllowAnyStatusCode]
            Task<Models.Eac3AudioConfiguration> CreateAsync([Body] Models.Eac3AudioConfiguration eac3AudioConfiguration);

            [Delete("/encoding/configurations/audio/eac3/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/eac3/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.Eac3AudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/eac3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Eac3AudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
