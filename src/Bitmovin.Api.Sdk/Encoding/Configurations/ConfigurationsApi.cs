using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Type;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio;
using Bitmovin.Api.Sdk.Encoding.Configurations.Subtitles;

namespace Bitmovin.Api.Sdk.Encoding.Configurations
{
    public class ConfigurationsApi
    {
        private readonly IConfigurationsApiClient _apiClient;

        public ConfigurationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IConfigurationsApiClient>();

            Type = new TypeApi(apiClientFactory);
            Video = new VideoApi(apiClientFactory);
            Audio = new AudioApi(apiClientFactory);
            Subtitles = new SubtitlesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ConfigurationsApi
        /// </summary>
        public static BitmovinApiBuilder<ConfigurationsApi> Builder => new BitmovinApiBuilder<ConfigurationsApi>();

        public TypeApi Type { get; private set; }
        public VideoApi Video { get; private set; }
        public AudioApi Audio { get; private set; }
        public SubtitlesApi Subtitles { get; private set; }
        
        /// <summary>
        /// List all Codec Configurations
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CodecConfiguration>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IConfigurationsApiClient
        {
            
            [Get("/encoding/configurations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CodecConfiguration>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
