using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Account.Organizations.Groups.Tenants;
using Bitmovin.Api.Sdk.Account.Organizations.Groups.Invitations;
using Bitmovin.Api.Sdk.Account.Organizations.Groups.Permissions;

namespace Bitmovin.Api.Sdk.Account.Organizations.Groups
{
    public class GroupsApi
    {
        private readonly IGroupsApiClient _apiClient;

        public GroupsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IGroupsApiClient>();

            Tenants = new TenantsApi(apiClientFactory);
            Invitations = new InvitationsApi(apiClientFactory);
            Permissions = new PermissionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of GroupsApi
        /// </summary>
        public static BitmovinApiBuilder<GroupsApi> Builder => new BitmovinApiBuilder<GroupsApi>();

        public TenantsApi Tenants { get; private set; }
        public InvitationsApi Invitations { get; private set; }
        public PermissionsApi Permissions { get; private set; }
        
        /// <summary>
        /// Add Group
        /// </summary>
        /// <param name="organizationId">Id of the organization</param>
        /// <param name="group">The request payload</param>
        public async Task<Models.Group> CreateAsync(string organizationId, Models.Group group)
        {
            return await _apiClient.CreateAsync(organizationId, group);
        }
        
        /// <summary>
        /// Delete Group
        /// </summary>
        /// <param name="organizationId">Id of the organization</param>
        /// <param name="groupId">Id of the group</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string organizationId, string groupId)
        {
            return await _apiClient.DeleteAsync(organizationId, groupId);
        }
        
        /// <summary>
        /// Group Details
        /// </summary>
        /// <param name="organizationId">Id of the organization</param>
        /// <param name="groupId">Id of the group.</param>
        public async Task<Models.Group> GetAsync(string organizationId, string groupId)
        {
            return await _apiClient.GetAsync(organizationId, groupId);
        }
        
        /// <summary>
        /// List Groups
        /// </summary>
        /// <param name="organizationId">Id of the organization</param>
        public async Task<Models.PaginationResponse<Models.Group>> ListAsync(string organizationId)
        {
            return await _apiClient.ListAsync(organizationId);
        }
        
        internal interface IGroupsApiClient
        {
            
            [Post("/account/organizations/{organization_id}/groups")]
            [AllowAnyStatusCode]
            Task<Models.Group> CreateAsync([Path("organization_id")] string organizationId, [Body] Models.Group group);
            
            [Delete("/account/organizations/{organization_id}/groups/{group_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId);
            
            [Get("/account/organizations/{organization_id}/groups/{group_id}")]
            [AllowAnyStatusCode]
            Task<Models.Group> GetAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId);
            
            [Get("/account/organizations/{organization_id}/groups")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Group>> ListAsync([Path("organization_id")] string organizationId);
            
        }
        
    }
}
