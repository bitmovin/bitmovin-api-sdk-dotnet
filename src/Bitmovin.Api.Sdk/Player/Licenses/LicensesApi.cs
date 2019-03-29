using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.Licenses.Domains;
using Bitmovin.Api.Sdk.Player.Licenses.ThirdPartyLicensing;

namespace Bitmovin.Api.Sdk.Player.Licenses
{
    public class LicensesApi
    {
        private readonly ILicensesApiClient _apiClient;

        public LicensesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILicensesApiClient>();

            Domains = new DomainsApi(apiClientFactory);
            ThirdPartyLicensing = new ThirdPartyLicensingApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LicensesApi
        /// </summary>
        public static BitmovinApiBuilder<LicensesApi> Builder => new BitmovinApiBuilder<LicensesApi>();

        public DomainsApi Domains { get; private set; }
        public ThirdPartyLicensingApi ThirdPartyLicensing { get; private set; }
        
        /// <summary>
        /// Get License
        /// </summary>
        /// <param name="licenseId">ID of the License</param>
        public async Task<Models.PlayerLicense> GetAsync(string licenseId)
        {
            return await _apiClient.GetAsync(licenseId);
        }
        
        /// <summary>
        /// List Player Licenses
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PlayerLicense>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface ILicensesApiClient
        {
            
            [Get("/player/licenses/{license_id}")]
            [AllowAnyStatusCode]
            Task<Models.PlayerLicense> GetAsync([Path("license_id")] string licenseId);
            
            [Get("/player/licenses")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PlayerLicense>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

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
