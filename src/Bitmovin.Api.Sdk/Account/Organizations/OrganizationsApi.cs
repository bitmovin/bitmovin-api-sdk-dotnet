﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Account.Organizations.SubOrganizations;
using Bitmovin.Api.Sdk.Account.Organizations.Groups;

namespace Bitmovin.Api.Sdk.Account.Organizations
{
    public class OrganizationsApi
    {
        private readonly IOrganizationsApiClient _apiClient;

        public OrganizationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IOrganizationsApiClient>();

            SubOrganizations = new SubOrganizationsApi(apiClientFactory);
            Groups = new GroupsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OrganizationsApi
        /// </summary>
        public static BitmovinApiBuilder<OrganizationsApi> Builder => new BitmovinApiBuilder<OrganizationsApi>();

        public SubOrganizationsApi SubOrganizations { get; private set; }
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
        /// Organization Details
        /// </summary>
        /// <param name="organizationId">ID of the organization</param>
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
            
            [Get("/account/organizations/{organization_id}")]
            [AllowAnyStatusCode]
            Task<Models.Organization> GetAsync([Path("organization_id")] string organizationId);
            
            [Get("/account/organizations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Organization>> ListAsync();
            
        }
        
    }
}
