using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.VirtualLicenses
{
    public class VirtualLicensesApi
    {
        private readonly IVirtualLicensesApiClient _apiClient;

        public VirtualLicensesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVirtualLicensesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of VirtualLicensesApi
        /// </summary>
        public static BitmovinApiBuilder<VirtualLicensesApi> Builder => new BitmovinApiBuilder<VirtualLicensesApi>();

        /// <summary>
        /// Create Virtual License
        /// </summary>
        /// <param name="virtualLicenseCreateRequest">Virtual License to be created</param>
        public async Task<Models.VirtualLicense> CreateAsync(Models.VirtualLicenseCreateRequest virtualLicenseCreateRequest)
        {
            return await _apiClient.CreateAsync(virtualLicenseCreateRequest);
        }

        internal interface IVirtualLicensesApiClient
        {
            [Post("/analytics/virtual-licenses")]
            [AllowAnyStatusCode]
            Task<Models.VirtualLicense> CreateAsync([Body] Models.VirtualLicenseCreateRequest virtualLicenseCreateRequest);
        }
    }
}
