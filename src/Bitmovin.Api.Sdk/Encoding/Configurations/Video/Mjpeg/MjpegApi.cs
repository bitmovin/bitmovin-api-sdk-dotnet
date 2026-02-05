using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Mjpeg.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video.Mjpeg
{
    /// <summary>
    /// API for MjpegApi
    /// </summary>
    public class MjpegApi
    {
        private readonly IMjpegApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the MjpegApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public MjpegApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMjpegApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MjpegApi
        /// </summary>
        public static BitmovinApiBuilder<MjpegApi> Builder => new BitmovinApiBuilder<MjpegApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create MJPEG Codec Configuration
        /// </summary>
        /// <param name="mjpegVideoConfiguration">The MJPEG Codec Configuration to be created</param>
        public async Task<Models.MjpegVideoConfiguration> CreateAsync(Models.MjpegVideoConfiguration mjpegVideoConfiguration)
        {
            return await _apiClient.CreateAsync(mjpegVideoConfiguration);
        }

        /// <summary>
        /// Delete MJPEG Codec Configuration
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }

        /// <summary>
        /// MJPEG Codec Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration (required)</param>
        public async Task<Models.MjpegVideoConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }

        /// <summary>
        /// List MJPEG Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.MjpegVideoConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IMjpegApiClient
        {
            [Post("/encoding/configurations/video/mjpeg")]
            [AllowAnyStatusCode]
            Task<Models.MjpegVideoConfiguration> CreateAsync([Body] Models.MjpegVideoConfiguration mjpegVideoConfiguration);

            [Delete("/encoding/configurations/video/mjpeg/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/mjpeg/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.MjpegVideoConfiguration> GetAsync([Path("configuration_id")] string configurationId);

            [Get("/encoding/configurations/video/mjpeg")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.MjpegVideoConfiguration>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
