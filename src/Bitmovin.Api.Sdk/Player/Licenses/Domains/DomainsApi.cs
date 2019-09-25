using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Player.Licenses.Domains
{
    public class DomainsApi
    {
        private readonly IDomainsApiClient _apiClient;

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
        /// <param name="licenseId">Id of the Player License</param>
        /// <param name="domain">The request payload</param>
        public async Task<Models.Domain> CreateAsync(string licenseId, Models.Domain domain)
        {
            return await _apiClient.CreateAsync(licenseId, domain);
        }
        
        /// <summary>
        /// Delete Domain
        /// </summary>
        /// <param name="licenseId">Id of license</param>
        /// <param name="domainId">Id of the domain</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string licenseId, string domainId)
        {
            return await _apiClient.DeleteAsync(licenseId, domainId);
        }
        
        /// <summary>
        /// List allowed Domains for Player License
        /// </summary>
        /// <param name="licenseId">Id of the Player License</param>
        public async Task<Models.PaginationResponse<Models.Domain>> ListAsync(string licenseId)
        {
            return await _apiClient.ListAsync(licenseId);
        }
        
        internal interface IDomainsApiClient
        {
            
            [Post("/player/licenses/{license_id}/domains")]
            [AllowAnyStatusCode]
            Task<Models.Domain> CreateAsync([Path("license_id")] string licenseId, [Body] Models.Domain domain);
            
            [Delete("/player/licenses/{license_id}/domains/{domain_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("license_id")] string licenseId, [Path("domain_id")] string domainId);
            
            [Get("/player/licenses/{license_id}/domains")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Domain>> ListAsync([Path("license_id")] string licenseId);
            
        }
        
    }
}
