using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.DvbSubtitle.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.DvbSubtitle
{
    public class DvbSubtitleApi
    {
        private readonly IDvbSubtitleApiClient _apiClient;

        public DvbSubtitleApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDvbSubtitleApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DvbSubtitleApi
        /// </summary>
        public static BitmovinApiBuilder<DvbSubtitleApi> Builder => new BitmovinApiBuilder<DvbSubtitleApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create DVB-SUB subtitle configuration
        /// </summary>
        /// <param name="dvbSubtitleConfiguration">The DVB-SUB subtitle configuration to be created</param>
        public async Task<Models.DvbSubtitleConfiguration> CreateAsync(Models.DvbSubtitleConfiguration dvbSubtitleConfiguration)
        {
            return await _apiClient.CreateAsync(dvbSubtitleConfiguration);
        }

        /// <summary>
        /// Delete DVB-SUB subtitle configuration
        /// </summary>
        /// <param name="configurationId">Id of the subtitle configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// DVB-SUB subtitle configuration details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.DvbSubtitleConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List DVB-SUB subtitle configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DvbSubtitleConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDvbSubtitleApiClient
        {
            [Post("/encoding/configurations/subtitles/dvb-subtitle")]
            [AllowAnyStatusCode]
            Task<Models.DvbSubtitleConfiguration> CreateAsync([Body] Models.DvbSubtitleConfiguration dvbSubtitleConfiguration);

            [Delete("/encoding/configurations/subtitles/dvb-subtitle/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/subtitles/dvb-subtitle/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.DvbSubtitleConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/subtitles/dvb-subtitle")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DvbSubtitleConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
