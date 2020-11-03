using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Interlace.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Interlace
{
    public class InterlaceApi
    {
        private readonly IInterlaceApiClient _apiClient;

        public InterlaceApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInterlaceApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of InterlaceApi
        /// </summary>
        public static BitmovinApiBuilder<InterlaceApi> Builder => new BitmovinApiBuilder<InterlaceApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Interlace Filter
        /// </summary>
        /// <param name="interlaceFilter">The Interlace Filter to be created</param>
        public async Task<Models.InterlaceFilter> CreateAsync(Models.InterlaceFilter interlaceFilter)
        {
            return await _apiClient.CreateAsync(interlaceFilter);
        }

        /// <summary>
        /// Delete Interlace Filter
        /// </summary>
        /// <param name="filterId">Id of the Interlace Filter (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Interlace Filter Details
        /// </summary>
        /// <param name="filterId">Id of the Interlace Filter (required)</param>
        public async Task<Models.InterlaceFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Interlace Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.InterlaceFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IInterlaceApiClient
        {
            [Post("/encoding/filters/interlace")]
            [AllowAnyStatusCode]
            Task<Models.InterlaceFilter> CreateAsync([Body] Models.InterlaceFilter interlaceFilter);

            [Delete("/encoding/filters/interlace/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/interlace/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.InterlaceFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/interlace")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.InterlaceFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
