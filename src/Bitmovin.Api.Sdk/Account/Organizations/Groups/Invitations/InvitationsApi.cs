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
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="invitation">Invitation details</param>
        public async Task<Models.Invitation> CreateAsync(string organizationId, string groupId, Models.Invitation invitation)
        {
            return await _apiClient.CreateAsync(organizationId, groupId, invitation);
        }

        /// <summary>
        /// Delete Invitation
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="invitationId">Id of the invitation. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string organizationId, string groupId, string invitationId)
        {
            return await _apiClient.DeleteAsync(organizationId, groupId, invitationId);
        }

        /// <summary>
        /// Invitation Details
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="invitationId">Id of the invitation. (required)</param>
        public async Task<Models.Invitation> GetAsync(string organizationId, string groupId, string invitationId)
        {
            return await _apiClient.GetAsync(organizationId, groupId, invitationId);
        }

        /// <summary>
        /// List Invitations
        /// </summary>
        /// <param name="organizationId">Id of the organization (required)</param>
        /// <param name="groupId">Id of the group (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Invitation>> ListAsync(string organizationId, string groupId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(organizationId, groupId, q);
        }

        internal interface IInvitationsApiClient
        {
            [Post("/account/organizations/{organization_id}/groups/{group_id}/invitations")]
            [AllowAnyStatusCode]
            Task<Models.Invitation> CreateAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Body] Models.Invitation invitation);

            [Delete("/account/organizations/{organization_id}/groups/{group_id}/invitations/{invitation_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Path("invitation_id")] string invitationId);

            [Get("/account/organizations/{organization_id}/groups/{group_id}/invitations/{invitation_id}")]
            [AllowAnyStatusCode]
            Task<Models.Invitation> GetAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [Path("invitation_id")] string invitationId);

            [Get("/account/organizations/{organization_id}/groups/{group_id}/invitations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Invitation>> ListAsync([Path("organization_id")] string organizationId, [Path("group_id")] string groupId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

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
