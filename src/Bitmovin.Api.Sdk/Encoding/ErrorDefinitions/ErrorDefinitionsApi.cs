using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.ErrorDefinitions
{
    public class ErrorDefinitionsApi
    {
        private readonly IErrorDefinitionsApiClient _apiClient;

        public ErrorDefinitionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IErrorDefinitionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ErrorDefinitionsApi
        /// </summary>
        public static BitmovinApiBuilder<ErrorDefinitionsApi> Builder => new BitmovinApiBuilder<ErrorDefinitionsApi>();

        /// <summary>
        /// List all possible encoding error definitions
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EncodingErrorDefinition>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IErrorDefinitionsApiClient
        {
            [Get("/encoding/error-definitions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EncodingErrorDefinition>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
