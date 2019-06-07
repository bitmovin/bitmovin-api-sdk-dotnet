﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.General.ErrorDefinitions
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
        /// List all possible api error definitions
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ApiErrorDefinition>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            
            [Get("/general/error-definitions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ApiErrorDefinition>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
