using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Organizations.SubOrganizations
{
    /// <summary>
    /// API for SubOrganizationsApi
    /// </summary>
    public class SubOrganizationsApi
    {
        private readonly ISubOrganizationsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SubOrganizationsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SubOrganizationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISubOrganizationsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of SubOrganizationsApi
        /// </summary>
        public static BitmovinApiBuilder<SubOrganizationsApi> Builder => new BitmovinApiBuilder<SubOrganizationsApi>();

        /// <summary>
        /// Organizations under given parent organization
        /// </summary>
        /// <param name="organizationId">ID of the parent organization (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Organization>> ListAsync(string organizationId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(organizationId, q);
        }

        internal interface ISubOrganizationsApiClient
        {
            [Get("/account/organizations/{organization_id}/sub-organizations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Organization>> ListAsync([Path("organization_id")] string organizationId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
