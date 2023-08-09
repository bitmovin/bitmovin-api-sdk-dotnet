using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.Search
{
    public class SearchApi
    {
        private readonly ISearchApiClient _apiClient;

        public SearchApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISearchApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of SearchApi
        /// </summary>
        public static BitmovinApiBuilder<SearchApi> Builder => new BitmovinApiBuilder<SearchApi>();

        /// <summary>
        /// Get paginated search results of VOD and Live streams
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StreamsSearchResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface ISearchApiClient
        {
            [Get("/streams/search")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StreamsSearchResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Query to search against
            /// </summary>
            public ListQueryParams Query(string query) => SetQueryParam("query", query);

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
