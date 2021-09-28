using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Licenses.Domains;

namespace Bitmovin.Api.Sdk.Analytics.Licenses
{
    public class LicensesApi
    {
        private readonly ILicensesApiClient _apiClient;

        public LicensesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILicensesApiClient>();
            Domains = new DomainsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LicensesApi
        /// </summary>
        public static BitmovinApiBuilder<LicensesApi> Builder => new BitmovinApiBuilder<LicensesApi>();

        public DomainsApi Domains { get; }

        /// <summary>
        /// Create Analytics License
        /// </summary>
        /// <param name="analyticsLicense">Analytics License to be created</param>
        public async Task<Models.AnalyticsLicense> CreateAsync(Models.AnalyticsLicense analyticsLicense)
        {
            return await _apiClient.CreateAsync(analyticsLicense);
        }

        /// <summary>
        /// Get License
        /// </summary>
        /// <param name="licenseId">License id (required)</param>
        public async Task<Models.AnalyticsLicense> GetAsync(string licenseId)
        {
            return await _apiClient.GetAsync(licenseId);
        }

        /// <summary>
        /// List Analytics Licenses
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AnalyticsLicense>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Update Analytics License
        /// </summary>
        /// <param name="licenseId">License id (required)</param>
        /// <param name="analyticsLicenseUpdateRequest">Analytics License details to be updated</param>
        public async Task<Models.AnalyticsLicense> UpdateAsync(string licenseId, Models.AnalyticsLicenseUpdateRequest analyticsLicenseUpdateRequest)
        {
            return await _apiClient.UpdateAsync(licenseId, analyticsLicenseUpdateRequest);
        }

        internal interface ILicensesApiClient
        {
            [Post("/analytics/licenses")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsLicense> CreateAsync([Body] Models.AnalyticsLicense analyticsLicense);

            [Get("/analytics/licenses/{license_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsLicense> GetAsync([Path("license_id")] string licenseId);

            [Get("/analytics/licenses")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AnalyticsLicense>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Put("/analytics/licenses/{license_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsLicense> UpdateAsync([Path("license_id")] string licenseId, [Body] Models.AnalyticsLicenseUpdateRequest analyticsLicenseUpdateRequest);
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
