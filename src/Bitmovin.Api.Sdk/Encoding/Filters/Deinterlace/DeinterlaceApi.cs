using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Deinterlace.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Deinterlace
{
    /// <summary>
    /// API for DeinterlaceApi
    /// </summary>
    public class DeinterlaceApi
    {
        private readonly IDeinterlaceApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DeinterlaceApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DeinterlaceApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDeinterlaceApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DeinterlaceApi
        /// </summary>
        public static BitmovinApiBuilder<DeinterlaceApi> Builder => new BitmovinApiBuilder<DeinterlaceApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Deinterlace Filter
        /// </summary>
        /// <param name="deinterlaceFilter">The Deinterlace Filter to be created</param>
        public async Task<Models.DeinterlaceFilter> CreateAsync(Models.DeinterlaceFilter deinterlaceFilter)
        {
            return await _apiClient.CreateAsync(deinterlaceFilter);
        }

        /// <summary>
        /// Delete Deinterlace Filter
        /// </summary>
        /// <param name="filterId">Id of the Deinterlace Filter (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Deinterlace Filter Details
        /// </summary>
        /// <param name="filterId">Id of the Deinterlace Filter (required)</param>
        public async Task<Models.DeinterlaceFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Deinterlace Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DeinterlaceFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDeinterlaceApiClient
        {
            [Post("/encoding/filters/deinterlace")]
            [AllowAnyStatusCode]
            Task<Models.DeinterlaceFilter> CreateAsync([Body] Models.DeinterlaceFilter deinterlaceFilter);

            [Delete("/encoding/filters/deinterlace/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/deinterlace/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.DeinterlaceFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/deinterlace")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DeinterlaceFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
