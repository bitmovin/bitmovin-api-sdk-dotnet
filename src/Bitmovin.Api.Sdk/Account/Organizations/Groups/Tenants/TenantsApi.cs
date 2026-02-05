using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Organizations.Groups.Tenants
{
    /// <summary>
    /// API for TenantsApi
    /// </summary>
    public class TenantsApi
    {
        private readonly ITenantsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the TenantsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public TenantsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITenantsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TenantsApi
        /// </summary>
        public static BitmovinApiBuilder<TenantsApi> Builder => new BitmovinApiBuilder<TenantsApi>();

        /// <summary>
        /// Add Tenant to Group
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="tenant">Tenant details</param>
        public async Task<Models.Tenant> CreateAsync(string organizationId, string groupId, Models.Tenant tenant)
        {
            return await _apiClient.CreateAsync(organizationId, groupId, tenant);
        }

        /// <summary>
        /// Delete Tenant
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="tenantId">Id of the tenant. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string organizationId, string groupId, string tenantId)
        {
            return await _apiClient.DeleteAsync(organizationId, groupId, tenantId);
        }

        /// <summary>
        /// Tenant Details
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="tenantId">Id of the tenant. (required)</param>
        public async Task<Models.Tenant> GetAsync(string organizationId, string groupId, string tenantId)
        {
            return await _apiClient.GetAsync(organizationId, groupId, tenantId);
        }

        /// <summary>
        /// List Tenants
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Tenant>> ListAsync(string organizationId, string groupId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(organizationId, groupId, q);
        }

        internal interface ITenantsApiClient
        {
            [Post("/account/organizations/{organization_id}/groups/{group_id}/tenants")]
            [AllowAnyStatusCode]
            Task<Models.Tenant> CreateAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Body] Models.Tenant tenant);

            [Delete("/account/organizations/{organization_id}/groups/{group_id}/tenants/{tenant_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Path("tenant_id")] string tenantId);

            [Get("/account/organizations/{organization_id}/groups/{group_id}/tenants/{tenant_id}")]
            [AllowAnyStatusCode]
            Task<Models.Tenant> GetAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Path("tenant_id")] string tenantId);

            [Get("/account/organizations/{organization_id}/groups/{group_id}/tenants")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Tenant>> ListAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
