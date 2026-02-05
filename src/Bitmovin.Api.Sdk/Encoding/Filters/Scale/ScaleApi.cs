using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Scale.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Scale
{
    /// <summary>
    /// API for ScaleApi
    /// </summary>
    public class ScaleApi
    {
        private readonly IScaleApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ScaleApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ScaleApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IScaleApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ScaleApi
        /// </summary>
        public static BitmovinApiBuilder<ScaleApi> Builder => new BitmovinApiBuilder<ScaleApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Scale Filter
        /// </summary>
        /// <param name="scaleFilter">The Scale Filter to be created</param>
        public async Task<Models.ScaleFilter> CreateAsync(Models.ScaleFilter scaleFilter)
        {
            return await _apiClient.CreateAsync(scaleFilter);
        }

        /// <summary>
        /// Delete Scale Filter
        /// </summary>
        /// <param name="filterId">Id of the scale filter (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Scale Filter Details
        /// </summary>
        /// <param name="filterId">Id of the scale filter (required)</param>
        public async Task<Models.ScaleFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Scale Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ScaleFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IScaleApiClient
        {
            [Post("/encoding/filters/scale")]
            [AllowAnyStatusCode]
            Task<Models.ScaleFilter> CreateAsync([Body] Models.ScaleFilter scaleFilter);

            [Delete("/encoding/filters/scale/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/scale/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.ScaleFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/scale")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ScaleFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
