using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Organizations.SubOrganizations
{
    public class SubOrganizationsApi
    {
        private readonly ISubOrganizationsApiClient _apiClient;

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
        public async Task<Models.PaginationResponse<Models.Organization>> ListAsync(string organizationId)
        {
            return await _apiClient.ListAsync(organizationId);
        }

        internal interface ISubOrganizationsApiClient
        {
            [Get("/account/organizations/{organization_id}/sub-organizations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Organization>> ListAsync([Path("organization_id")] string organizationId);
        }
    }
}
