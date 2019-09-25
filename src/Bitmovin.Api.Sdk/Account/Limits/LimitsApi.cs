using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Limits
{
    public class LimitsApi
    {
        private readonly ILimitsApiClient _apiClient;

        public LimitsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILimitsApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of LimitsApi
        /// </summary>
        public static BitmovinApiBuilder<LimitsApi> Builder => new BitmovinApiBuilder<LimitsApi>();

        
        /// <summary>
        /// Organization Limits
        /// </summary>
        public async Task<Models.PaginationResponse<Models.ResourceLimitContainer>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }
        
        internal interface ILimitsApiClient
        {
            
            [Get("/account/limits")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ResourceLimitContainer>> ListAsync();
            
        }
        
    }
}
