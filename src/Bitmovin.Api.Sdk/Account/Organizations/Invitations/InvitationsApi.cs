using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Organizations.Invitations
{
    /// <summary>
    /// API for InvitationsApi
    /// </summary>
    public class InvitationsApi
    {
        private readonly IInvitationsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the InvitationsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public InvitationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInvitationsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of InvitationsApi
        /// </summary>
        public static BitmovinApiBuilder<InvitationsApi> Builder => new BitmovinApiBuilder<InvitationsApi>();

        /// <summary>
        /// List all pending invitations of an org id
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        public async Task<Models.PaginationResponse<Models.OrganizationPendingInvitation>> ListAsync(string organizationId)
        {
            return await _apiClient.ListAsync(organizationId);
        }

        internal interface IInvitationsApiClient
        {
            [Get("/account/organizations/{organization_id}/invitations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.OrganizationPendingInvitation>> ListAsync([Path("organization_id")] string organizationId);
        }
    }
}
