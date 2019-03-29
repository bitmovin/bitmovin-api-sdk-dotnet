using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Licenses.Domains
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
        /// <param name="licenseId">License id</param>
        /// <param name="domain">The request payload</param>
        public async Task<Models.Domain> CreateAsync(string licenseId, Models.Domain domain)
        {
            return await _apiClient.CreateAsync(licenseId, domain);
        }
        
        /// <summary>
        /// Delete Domain
        /// </summary>
        /// <param name="licenseId">License id</param>
        /// <param name="domainId">id of domain to delete</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string licenseId, string domainId)
        {
            return await _apiClient.DeleteAsync(licenseId, domainId);
        }
        
        /// <summary>
        /// List License Domains
        /// </summary>
        /// <param name="licenseId">License id</param>
        public async Task<Models.DomainList> GetAsync(string licenseId)
        {
            return await _apiClient.GetAsync(licenseId);
        }
        
        internal interface IDomainsApiClient
        {
            
            [Post("/analytics/licenses/{license_id}/domains")]
            [AllowAnyStatusCode]
            Task<Models.Domain> CreateAsync([Path("license_id")] string licenseId, [Body] Models.Domain domain);
            
            [Delete("/analytics/licenses/{license_id}/domains/{domain_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("license_id")] string licenseId, [Path("domain_id")] string domainId);
            
            [Get("/analytics/licenses/{license_id}/domains")]
            [AllowAnyStatusCode]
            Task<Models.DomainList> GetAsync([Path("license_id")] string licenseId);
            
        }
        
    }
}
