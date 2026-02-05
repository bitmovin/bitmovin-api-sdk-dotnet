using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Information
{
    /// <summary>
    /// API for InformationApi
    /// </summary>
    public class InformationApi
    {
        private readonly IInformationApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the InformationApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public InformationApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IInformationApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of InformationApi
        /// </summary>
        public static BitmovinApiBuilder<InformationApi> Builder => new BitmovinApiBuilder<InformationApi>();

        /// <summary>
        /// Current Account Information
        /// </summary>
        public async Task<Models.AccountInformation> GetAsync()
        {
            return await _apiClient.GetAsync();
        }

        internal interface IInformationApiClient
        {
            [Get("/account/information")]
            [AllowAnyStatusCode]
            Task<Models.AccountInformation> GetAsync();
        }
    }
}
