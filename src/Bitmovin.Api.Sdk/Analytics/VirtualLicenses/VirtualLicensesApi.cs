using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.VirtualLicenses
{
    /// <summary>
    /// API for VirtualLicensesApi
    /// </summary>
    public class VirtualLicensesApi
    {
        private readonly IVirtualLicensesApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the VirtualLicensesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public VirtualLicensesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVirtualLicensesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of VirtualLicensesApi
        /// </summary>
        public static BitmovinApiBuilder<VirtualLicensesApi> Builder => new BitmovinApiBuilder<VirtualLicensesApi>();

        /// <summary>
        /// Create Analytics Virtual License
        /// </summary>
        /// <param name="analyticsVirtualLicenseRequest">Analytics Virtual License to be created</param>
        public async Task<Models.AnalyticsVirtualLicense> CreateAsync(Models.AnalyticsVirtualLicenseRequest analyticsVirtualLicenseRequest)
        {
            return await _apiClient.CreateAsync(analyticsVirtualLicenseRequest);
        }

        /// <summary>
        /// Delete Analytics Virtual License
        /// </summary>
        /// <param name="virtualLicenseId">Virtual License id (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string virtualLicenseId)
        {
            return await _apiClient.DeleteAsync(virtualLicenseId);
        }

        /// <summary>
        /// Analytics Virtual License
        /// </summary>
        /// <param name="virtualLicenseId">Virtual license id (required)</param>
        public async Task<Models.AnalyticsVirtualLicense> GetAsync(string virtualLicenseId)
        {
            return await _apiClient.GetAsync(virtualLicenseId);
        }

        /// <summary>
        /// List Analytics Virtual Licenses
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AnalyticsVirtualLicense>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// Update Analytics Virtual License
        /// </summary>
        /// <param name="virtualLicenseId">Virtual license id (required)</param>
        /// <param name="analyticsVirtualLicenseRequest">Analytics Virtual License details to be updated</param>
        public async Task<Models.AnalyticsVirtualLicense> UpdateAsync(string virtualLicenseId, Models.AnalyticsVirtualLicenseRequest analyticsVirtualLicenseRequest)
        {
            return await _apiClient.UpdateAsync(virtualLicenseId, analyticsVirtualLicenseRequest);
        }

        internal interface IVirtualLicensesApiClient
        {
            [Post("/analytics/virtual-licenses")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsVirtualLicense> CreateAsync([Body] Models.AnalyticsVirtualLicenseRequest analyticsVirtualLicenseRequest);

            [Delete("/analytics/virtual-licenses/{virtual_license_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("virtual_license_id")] string virtualLicenseId);

            [Get("/analytics/virtual-licenses/{virtual_license_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsVirtualLicense> GetAsync([Path("virtual_license_id")] string virtualLicenseId);

            [Get("/analytics/virtual-licenses")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AnalyticsVirtualLicense>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Put("/analytics/virtual-licenses/{virtual_license_id}")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsVirtualLicense> UpdateAsync([Path("virtual_license_id")] string virtualLicenseId, [Body] Models.AnalyticsVirtualLicenseRequest analyticsVirtualLicenseRequest);
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
