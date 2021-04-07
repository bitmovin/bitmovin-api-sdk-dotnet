using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.AudioMix.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.AudioMix
{
    public class AudioMixApi
    {
        private readonly IAudioMixApiClient _apiClient;

        public AudioMixApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAudioMixApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AudioMixApi
        /// </summary>
        public static BitmovinApiBuilder<AudioMixApi> Builder => new BitmovinApiBuilder<AudioMixApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Audio Mix Filter
        /// </summary>
        /// <param name="audioMixFilter">The Audio Mix Filter to be created</param>
        public async Task<Models.AudioMixFilter> CreateAsync(Models.AudioMixFilter audioMixFilter)
        {
            return await _apiClient.CreateAsync(audioMixFilter);
        }

        /// <summary>
        /// Delete Audio Mix Filter
        /// </summary>
        /// <param name="filterId">Id of the Audio Mix Filter. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Audio Mix Filter Details
        /// </summary>
        /// <param name="filterId">Id of the Audio Mix Filter. (required)</param>
        public async Task<Models.AudioMixFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Audio Mix Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AudioMixFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAudioMixApiClient
        {
            [Post("/encoding/filters/audio-mix")]
            [AllowAnyStatusCode]
            Task<Models.AudioMixFilter> CreateAsync([Body] Models.AudioMixFilter audioMixFilter);

            [Delete("/encoding/filters/audio-mix/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/audio-mix/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.AudioMixFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/audio-mix")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AudioMixFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Filter filters by name
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
