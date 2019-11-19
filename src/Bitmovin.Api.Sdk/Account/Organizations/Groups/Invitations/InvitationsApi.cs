using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Organizations.Groups.Invitations
{
    public class InvitationsApi
    {
        private readonly IInvitationsApiClient _apiClient;

        public InvitationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInvitationsApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of InvitationsApi
        /// </summary>
        public static BitmovinApiBuilder<InvitationsApi> Builder => new BitmovinApiBuilder<InvitationsApi>();

        
        /// <summary>
        /// Add Invitation to Group
        /// </summary>
        /// <param name="organizationId">Id of the organization</param>
        /// <param name="groupId">Id of the group</param>
        /// <param name="invitation">The request payload</param>
        public async Task<Models.Invitation> CreateAsync(string organizationId, string groupId, Models.Invitation invitation)
        {
            return await _apiClient.CreateAsync(organizationId, groupId, invitation);
        }
        
        /// <summary>
        /// List Invitations
        /// </summary>
        /// <param name="organizationId">Id of the organization</param>
        /// <param name="groupId">Id of the group</param>
        public async Task<Models.PaginationResponse<Models.Invitation>> ListAsync(string organizationId, string groupId)
        {
            return await _apiClient.ListAsync(organizationId, groupId);
        }
        
        internal interface IInvitationsApiClient
        {
            
            [Post("/account/organizations/{organization_id}/groups/{group_id}/invitations")]
            [AllowAnyStatusCode]
            Task<Models.Invitation> CreateAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Body] Models.Invitation invitation);
            
            [Get("/account/organizations/{organization_id}/groups/{group_id}/invitations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Invitation>> ListAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId);
            
        }
        
    }
}
