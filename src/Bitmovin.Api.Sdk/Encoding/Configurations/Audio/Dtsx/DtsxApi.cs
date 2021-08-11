using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Dtsx.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Dtsx
{
    public class DtsxApi
    {
        private readonly IDtsxApiClient _apiClient;

        public DtsxApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDtsxApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DtsxApi
        /// </summary>
        public static BitmovinApiBuilder<DtsxApi> Builder => new BitmovinApiBuilder<DtsxApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create DTS:X Codec Configuration
        /// </summary>
        /// <param name="dtsXAudioConfiguration">The DTS:X Codec Configuration to be created</param>
        public async Task<Models.DtsXAudioConfiguration> CreateAsync(Models.DtsXAudioConfiguration dtsXAudioConfiguration)
        {
            return await _apiClient.CreateAsync(dtsXAudioConfiguration);
        }

        /// <summary>
        /// Delete DTS:X Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// DTS:X Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.DtsXAudioConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List DTS:X Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DtsXAudioConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDtsxApiClient
        {
            [Post("/encoding/configurations/audio/dtsx")]
            [AllowAnyStatusCode]
            Task<Models.DtsXAudioConfiguration> CreateAsync([Body] Models.DtsXAudioConfiguration dtsXAudioConfiguration);

            [Delete("/encoding/configurations/audio/dtsx/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dtsx/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.DtsXAudioConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/audio/dtsx")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DtsXAudioConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
