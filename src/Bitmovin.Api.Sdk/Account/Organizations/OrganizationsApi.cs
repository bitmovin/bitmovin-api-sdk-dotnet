using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Account.Organizations.Groups;

namespace Bitmovin.Api.Sdk.Account.Organizations
{
    public class OrganizationsApi
    {
        private readonly IOrganizationsApiClient _apiClient;

        public OrganizationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IOrganizationsApiClient>();

            Groups = new GroupsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OrganizationsApi
        /// </summary>
        public static BitmovinApiBuilder<OrganizationsApi> Builder => new BitmovinApiBuilder<OrganizationsApi>();

        public GroupsApi Groups { get; private set; }
        
        /// <summary>
        /// Add Organization
        /// </summary>
        /// <param name="organization">The request payload</param>
        public async Task<Models.Organization> CreateAsync(Models.Organization organization)
        {
            return await _apiClient.CreateAsync(organization);
        }
        
        /// <summary>
        /// Delete Organization
        /// </summary>
        /// <param name="organizationId">Id of the organization</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string organizationId)
        {
            return await _apiClient.DeleteAsync(organizationId);
        }
        
        /// <summary>
        /// Organization Details
        /// </summary>
        /// <param name="organizationId">Id of the organization</param>
        public async Task<Models.Organization> GetAsync(string organizationId)
        {
            return await _apiClient.GetAsync(organizationId);
        }
        
        /// <summary>
        /// List Organizations
        /// </summary>
        public async Task<Models.PaginationResponse<Models.Organization>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }
        
        internal interface IOrganizationsApiClient
        {
            
            [Post("/account/organizations")]
            [AllowAnyStatusCode]
            Task<Models.Organization> CreateAsync([Body] Models.Organization organization);
            
            [Delete("/account/organizations/{organization_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("organization_id")] string organizationId);
            
            [Get("/account/organizations/{organization_id}")]
            [AllowAnyStatusCode]
            Task<Models.Organization> GetAsync([Path("organization_id")] string organizationId);
            
            [Get("/account/organizations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Organization>> ListAsync();
            
        }
        
    }
}
