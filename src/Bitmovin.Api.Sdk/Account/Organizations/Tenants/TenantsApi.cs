using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Organizations.Tenants
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
        /// List all Tenants with their groups for a given organization
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        public async Task<Models.PaginationResponse<Models.TenantWithGroups>> ListAsync(string organizationId)
        {
            return await _apiClient.ListAsync(organizationId);
        }

        internal interface ITenantsApiClient
        {
            [Get("/account/organizations/{organization_id}/tenants")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TenantWithGroups>> ListAsync([Path("organization_id")] string organizationId);
        }
    }
}
