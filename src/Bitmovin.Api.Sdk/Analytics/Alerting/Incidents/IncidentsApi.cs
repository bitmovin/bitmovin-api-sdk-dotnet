using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Alerting.Incidents
{
    public class IncidentsApi
    {
        private readonly IIncidentsApiClient _apiClient;

        public IncidentsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IIncidentsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of IncidentsApi
        /// </summary>
        public static BitmovinApiBuilder<IncidentsApi> Builder => new BitmovinApiBuilder<IncidentsApi>();

        /// <summary>
        /// List Incidents
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AnalyticsIncident>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        /// <summary>
        /// List Incidents per license
        /// </summary>
        /// <param name="licenseKey">License key (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AnalyticsIncident>> ListByLicenseKeyAsync(string licenseKey, params Func<ListByLicenseKeyQueryParams, ListByLicenseKeyQueryParams>[] queryParams)
        {
            ListByLicenseKeyQueryParams q = new ListByLicenseKeyQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListByLicenseKeyAsync(licenseKey, q);
        }

        internal interface IIncidentsApiClient
        {
            [Get("/analytics/alerting/incidents")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AnalyticsIncident>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

            [Get("/analytics/alerting/incidents/{license_key}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AnalyticsIncident>> ListByLicenseKeyAsync([Path("license_key")] string licenseKey, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 10, maximum is 100
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

        public class ListByLicenseKeyQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListByLicenseKeyQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 10, maximum is 100
            /// </summary>
            public ListByLicenseKeyQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListByLicenseKeyQueryParams SetQueryParam<T>(string key, T value)
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
