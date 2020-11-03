using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H264.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video.H264
{
    public class H264Api
    {
        private readonly IH264ApiClient _apiClient;

        public H264Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IH264ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of H264Api
        /// </summary>
        public static BitmovinApiBuilder<H264Api> Builder => new BitmovinApiBuilder<H264Api>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create H264/AVC Codec Configuration
        /// </summary>
        /// <param name="h264VideoConfiguration">The H264/AVC Codec Configuration to be created</param>
        public async Task<Models.H264VideoConfiguration> CreateAsync(Models.H264VideoConfiguration h264VideoConfiguration)
        {
            return await _apiClient.CreateAsync(h264VideoConfiguration);
        }

        /// <summary>
        /// Delete H264/AVC Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// H264/AVC Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.H264VideoConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List H264/AVC Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.H264VideoConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IH264ApiClient
        {
            [Post("/encoding/configurations/video/h264")]
            [AllowAnyStatusCode]
            Task<Models.H264VideoConfiguration> CreateAsync([Body] Models.H264VideoConfiguration h264VideoConfiguration);

            [Delete("/encoding/configurations/video/h264/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/h264/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.H264VideoConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/h264")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.H264VideoConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
