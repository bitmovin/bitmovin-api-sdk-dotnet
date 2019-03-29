using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.Login
{
    public class LoginApi
    {
        private readonly ILoginApiClient _apiClient;

        public LoginApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILoginApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of LoginApi
        /// </summary>
        public static BitmovinApiBuilder<LoginApi> Builder => new BitmovinApiBuilder<LoginApi>();

        
        /// <summary>
        /// Login
        /// </summary>
        /// <param name="login">The request payload</param>
        public async Task<Models.AccountInformation> CreateAsync(Models.Login login)
        {
            return await _apiClient.CreateAsync(login);
        }
        
        internal interface ILoginApiClient
        {
            
            [Post("/account/login")]
            [AllowAnyStatusCode]
            Task<Models.AccountInformation> CreateAsync([Body] Models.Login login);
            
        }
        
    }
}
