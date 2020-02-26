using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.AudioVolume.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.AudioVolume
{
    public class AudioVolumeApi
    {
        private readonly IAudioVolumeApiClient _apiClient;

        public AudioVolumeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAudioVolumeApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AudioVolumeApi
        /// </summary>
        public static BitmovinApiBuilder<AudioVolumeApi> Builder => new BitmovinApiBuilder<AudioVolumeApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Audio Volume Filter
        /// </summary>
        /// <param name="audioVolumeFilter">The Audio Volume Filter to be created</param>
        public async Task<Models.AudioVolumeFilter> CreateAsync(Models.AudioVolumeFilter audioVolumeFilter)
        {
            return await _apiClient.CreateAsync(audioVolumeFilter);
        }

        /// <summary>
        /// Delete Audio Volume Filter
        /// </summary>
        /// <param name="filterId">Id of the Audio volume configuration. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Audio Volume Filter Details
        /// </summary>
        /// <param name="filterId">Id of the audio volume configuration. (required)</param>
        public async Task<Models.AudioVolumeFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Audio Volume Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AudioVolumeFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAudioVolumeApiClient
        {
            [Post("/encoding/filters/audio-volume")]
            [AllowAnyStatusCode]
            Task<Models.AudioVolumeFilter> CreateAsync([Body] Models.AudioVolumeFilter audioVolumeFilter);

            [Delete("/encoding/filters/audio-volume/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/audio-volume/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.AudioVolumeFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/audio-volume")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AudioVolumeFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
