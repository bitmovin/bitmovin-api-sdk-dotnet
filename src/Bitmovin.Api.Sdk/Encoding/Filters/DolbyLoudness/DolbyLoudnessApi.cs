using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.DolbyLoudness.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.DolbyLoudness
{
    /// <summary>
    /// API for DolbyLoudnessApi
    /// </summary>
    public class DolbyLoudnessApi
    {
        private readonly IDolbyLoudnessApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DolbyLoudnessApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DolbyLoudnessApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDolbyLoudnessApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DolbyLoudnessApi
        /// </summary>
        public static BitmovinApiBuilder<DolbyLoudnessApi> Builder => new BitmovinApiBuilder<DolbyLoudnessApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Dolby Loudness Filter
        /// </summary>
        /// <param name="dolbyLoudnessFilter">The Dolby Loudness Filter to be created</param>
        public async Task<Models.DolbyLoudnessFilter> CreateAsync(Models.DolbyLoudnessFilter dolbyLoudnessFilter)
        {
            return await _apiClient.CreateAsync(dolbyLoudnessFilter);
        }

        /// <summary>
        /// Delete Dolby Loudness Filter
        /// </summary>
        /// <param name="filterId">Id of the Dolby Loudness filter. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Get Dolby Loudness Filter details
        /// </summary>
        /// <param name="filterId">Id of the Dolby Loudness filter. (required)</param>
        public async Task<Models.DolbyLoudnessFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Dolby Loudness Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DolbyLoudnessFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDolbyLoudnessApiClient
        {
            [Post("/encoding/filters/dolby-loudness")]
            [AllowAnyStatusCode]
            Task<Models.DolbyLoudnessFilter> CreateAsync([Body] Models.DolbyLoudnessFilter dolbyLoudnessFilter);

            [Delete("/encoding/filters/dolby-loudness/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/dolby-loudness/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.DolbyLoudnessFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/dolby-loudness")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DolbyLoudnessFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
