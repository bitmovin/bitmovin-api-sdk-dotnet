using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Organizations.Groups.Permissions
{
    public class PermissionsApi
    {
        private readonly IPermissionsApiClient _apiClient;

        public PermissionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPermissionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of PermissionsApi
        /// </summary>
        public static BitmovinApiBuilder<PermissionsApi> Builder => new BitmovinApiBuilder<PermissionsApi>();

        /// <summary>
        /// Set Group Permissions
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="acl">Group Permissions</param>
        public async Task<Models.Acl> CreateAsync(string organizationId, string groupId, Models.Acl acl)
        {
            return await _apiClient.CreateAsync(organizationId, groupId, acl);
        }

        /// <summary>
        /// Delete Permission
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="permissionId">Id of the permission (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string organizationId, string groupId, string permissionId)
        {
            return await _apiClient.DeleteAsync(organizationId, groupId, permissionId);
        }

        /// <summary>
        /// Get Group Permissions
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        public async Task<Models.PaginationResponse<Models.Acl>> ListAsync(string organizationId, string groupId)
        {
            return await _apiClient.ListAsync(organizationId, groupId);
        }

        internal interface IPermissionsApiClient
        {
            [Post("/account/organizations/{organization_id}/groups/{group_id}/permissions")]
            [AllowAnyStatusCode]
            Task<Models.Acl> CreateAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Body] Models.Acl acl);

            [Delete("/account/organizations/{organization_id}/groups/{group_id}/permissions/{permission_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Path("permission_id")] string permissionId);

            [Get("/account/organizations/{organization_id}/groups/{group_id}/permissions")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Acl>> ListAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId);
        }
    }
}
