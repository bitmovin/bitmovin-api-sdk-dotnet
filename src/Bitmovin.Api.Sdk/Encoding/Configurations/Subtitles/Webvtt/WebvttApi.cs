using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.Webvtt.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles.Webvtt
{
    public class WebvttApi
    {
        private readonly IWebvttApiClient _apiClient;

        public WebvttApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWebvttApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WebvttApi
        /// </summary>
        public static BitmovinApiBuilder<WebvttApi> Builder => new BitmovinApiBuilder<WebvttApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Create WebVtt Subtitle Configuration
        /// </summary>
        /// <param name="webVttConfiguration">The request payload</param>
        public async Task<Models.WebVttConfiguration> CreateAsync(Models.WebVttConfiguration webVttConfiguration)
        {
            return await _apiClient.CreateAsync(webVttConfiguration);
        }
        
        /// <summary>
        /// Delete WebVtt Subtitle Configuration
        /// </summary>
        /// <param name="configurationId">Id of the subtitle configuration</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string configurationId)
        {
            return await _apiClient.DeleteAsync(configurationId);
        }
        
        /// <summary>
        /// WebVtt Subtitle Configuration Details
        /// </summary>
        /// <param name="configurationId">Id of the codec configuration</param>
        public async Task<Models.WebVttConfiguration> GetAsync(string configurationId)
        {
            return await _apiClient.GetAsync(configurationId);
        }
        
        /// <summary>
        /// List WebVtt Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.WebVttConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IWebvttApiClient
        {
            
            [Post("/encoding/configurations/subtitles/webvtt/")]
            [AllowAnyStatusCode]
            Task<Models.WebVttConfiguration> CreateAsync([Body] Models.WebVttConfiguration webVttConfiguration);
            
            [Delete("/encoding/configurations/subtitles/webvtt/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/subtitles/webvtt/{configuration_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebVttConfiguration> GetAsync([Path("configuration_id")] string configurationId);
            
            [Get("/encoding/configurations/subtitles/webvtt/")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.WebVttConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

            /// <summary>
            /// Filter configuration by name
            /// </summary>
            public ListQueryParams Name(string Name) => SetQueryParam("name", Name);

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
