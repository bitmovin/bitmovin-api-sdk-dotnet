using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.Search
{
    /// <summary>
    /// API for SearchApi
    /// </summary>
    public class SearchApi
    {
        private readonly ISearchApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SearchApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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
        public async Task<Models.PaginationResponse<Models.StreamsResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            Task<Models.PaginationResponse<Models.StreamsResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Query to search for in a streams&#39; title, description and ID
            /// </summary>
            public ListQueryParams Query(string query) => SetQueryParam("query", query);

            /// <summary>
            /// Type of stream to search for
            /// </summary>
            public ListQueryParams Type(Models.StreamsType type) => SetQueryParam("type", type);

            /// <summary>
            /// Status of the streams to search for
            /// </summary>
            public ListQueryParams Status(Models.StreamsVideoStatus status) => SetQueryParam("status", status);

            /// <summary>
            /// Upper limit for the creation date of found streams as UTC in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
            /// </summary>
            public ListQueryParams CreatedBefore(string createdBefore) => SetQueryParam("createdBefore", createdBefore);

            /// <summary>
            /// Lower limit for the creation date of found streams as UTC in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
            /// </summary>
            public ListQueryParams CreatedAfter(string createdAfter) => SetQueryParam("createdAfter", createdAfter);

            /// <summary>
            /// Filter for token-protected/signed streams
            /// </summary>
            public ListQueryParams Signed(bool? signed) => SetQueryParam("signed", signed);

            /// <summary>
            /// Filter for domain-restricted streams
            /// </summary>
            public ListQueryParams DomainRestricted(bool? domainRestricted) => SetQueryParam("domainRestricted", domainRestricted);

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
