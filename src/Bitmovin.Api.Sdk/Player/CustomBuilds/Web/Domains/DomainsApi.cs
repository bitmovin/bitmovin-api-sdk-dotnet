using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.CustomBuilds.Web.Domains
{
    /// <summary>
    /// API for DomainsApi
    /// </summary>
    public class DomainsApi
    {
        private readonly IDomainsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DomainsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DomainsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDomainsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DomainsApi
        /// </summary>
        public static BitmovinApiBuilder<DomainsApi> Builder => new BitmovinApiBuilder<DomainsApi>();

        /// <summary>
        /// Add Domain
        /// </summary>
        /// <param name="customWebPlayerBuildDomain">The Domain to be added</param>
        public async Task<Models.CustomWebPlayerBuildDomain> CreateAsync(Models.CustomWebPlayerBuildDomain customWebPlayerBuildDomain)
        {
            return await _apiClient.CreateAsync(customWebPlayerBuildDomain);
        }

        /// <summary>
        /// Delete Domain
        /// </summary>
        /// <param name="domainId">Id of the domain (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string domainId)
        {
            return await _apiClient.DeleteAsync(domainId);
        }

        /// <summary>
        /// Get Domain Details
        /// </summary>
        /// <param name="domainId">Id of the domain (required)</param>
        public async Task<Models.CustomWebPlayerBuildDomain> GetAsync(string domainId)
        {
            return await _apiClient.GetAsync(domainId);
        }

        /// <summary>
        /// List Domain Details
        /// </summary>
        public async Task<Models.PaginationResponse<Models.CustomWebPlayerBuildDomain>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }

        internal interface IDomainsApiClient
        {
            [Post("/player/custom-builds/web/domains")]
            [AllowAnyStatusCode]
            Task<Models.CustomWebPlayerBuildDomain> CreateAsync([Body] Models.CustomWebPlayerBuildDomain customWebPlayerBuildDomain);

            [Delete("/player/custom-builds/web/domains/{domain_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("domain_id")] string domainId);

            [Get("/player/custom-builds/web/domains/{domain_id}")]
            [AllowAnyStatusCode]
            Task<Models.CustomWebPlayerBuildDomain> GetAsync([Path("domain_id")] string domainId);

            [Get("/player/custom-builds/web/domains")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CustomWebPlayerBuildDomain>> ListAsync();
        }
    }
}
