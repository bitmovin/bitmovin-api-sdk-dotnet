using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Player.Licenses.Analytics;
using Bitmovin.Api.Sdk.Player.Licenses.Domains;
using Bitmovin.Api.Sdk.Player.Licenses.ThirdPartyLicensing;

namespace Bitmovin.Api.Sdk.Player.Licenses
{
    /// <summary>
    /// API for LicensesApi
    /// </summary>
    public class LicensesApi
    {
        private readonly ILicensesApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the LicensesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public LicensesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILicensesApiClient>();
            Analytics = new AnalyticsApi(apiClientFactory);
            Domains = new DomainsApi(apiClientFactory);
            ThirdPartyLicensing = new ThirdPartyLicensingApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LicensesApi
        /// </summary>
        public static BitmovinApiBuilder<LicensesApi> Builder => new BitmovinApiBuilder<LicensesApi>();

        /// <summary>
        /// Gets the Analytics API
        /// </summary>
        public AnalyticsApi Analytics { get; }
        /// <summary>
        /// Gets the Domains API
        /// </summary>
        public DomainsApi Domains { get; }
        /// <summary>
        /// Gets the ThirdPartyLicensing API
        /// </summary>
        public ThirdPartyLicensingApi ThirdPartyLicensing { get; }

        /// <summary>
        /// Create Player License
        /// </summary>
        /// <param name="playerLicense">Player License to be created</param>
        public async Task<Models.PlayerLicense> CreateAsync(Models.PlayerLicense playerLicense)
        {
            return await _apiClient.CreateAsync(playerLicense);
        }

        /// <summary>
        /// Get License
        /// </summary>
        /// <param name="licenseId">ID of the License (required)</param>
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

        /// <summary>
        /// Update License
        /// </summary>
        /// <param name="licenseId">License id (required)</param>
        /// <param name="playerLicenseUpdateRequest">Player License details to be updated</param>
        public async Task<Models.PlayerLicense> UpdateAsync(string licenseId, Models.PlayerLicenseUpdateRequest playerLicenseUpdateRequest)
        {
            return await _apiClient.UpdateAsync(licenseId, playerLicenseUpdateRequest);
        }

        internal interface ILicensesApiClient
        {
            [Post("/player/licenses")]
            [AllowAnyStatusCode]
            Task<Models.PlayerLicense> CreateAsync([Body] Models.PlayerLicense playerLicense);

            [Get("/player/licenses/{license_id}")]
            [AllowAnyStatusCode]
            Task<Models.PlayerLicense> GetAsync([Path("license_id")] string licenseId);

            [Get("/player/licenses")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PlayerLicense>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Put("/player/licenses/{license_id}")]
            [AllowAnyStatusCode]
            Task<Models.PlayerLicense> UpdateAsync([Path("license_id")] string licenseId, [Body] Models.PlayerLicenseUpdateRequest playerLicenseUpdateRequest);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
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
