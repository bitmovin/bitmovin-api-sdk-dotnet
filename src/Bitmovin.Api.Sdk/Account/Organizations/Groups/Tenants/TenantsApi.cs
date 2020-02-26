using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Organizations.Groups.Tenants
{
    public class TenantsApi
    {
        private readonly ITenantsApiClient _apiClient;

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
        public async Task<Models.PaginationResponse<Models.Tenant>> ListAsync(string organizationId, string groupId)
        {
            return await _apiClient.ListAsync(organizationId, groupId);
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
            Task<Models.PaginationResponse<Models.Tenant>> ListAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId);
        }
    }
}
