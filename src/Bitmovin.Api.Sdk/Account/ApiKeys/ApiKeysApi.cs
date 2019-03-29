using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Account.ApiKeys
{
    public class ApiKeysApi
    {
        private readonly IApiKeysApiClient _apiClient;

        public ApiKeysApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IApiKeysApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of ApiKeysApi
        /// </summary>
        public static BitmovinApiBuilder<ApiKeysApi> Builder => new BitmovinApiBuilder<ApiKeysApi>();

        
        /// <summary>
        /// Create Api Key
        /// </summary>
        public async Task<Models.AccountApiKey> CreateAsync()
        {
            return await _apiClient.CreateAsync();
        }
        
        /// <summary>
        /// Delete Api Key
        /// </summary>
        /// <param name="apiKeyId">Id of the api key</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string apiKeyId)
        {
            return await _apiClient.DeleteAsync(apiKeyId);
        }
        
        /// <summary>
        /// Get Api Key
        /// </summary>
        /// <param name="apiKeyId">Id of the api key</param>
        public async Task<Models.AccountApiKey> GetAsync(string apiKeyId)
        {
            return await _apiClient.GetAsync(apiKeyId);
        }
        
        /// <summary>
        /// List Api Keys
        /// </summary>
        public async Task<Models.PaginationResponse<Models.AccountApiKey>> ListAsync()
        {
            return await _apiClient.ListAsync();
        }
        
        internal interface IApiKeysApiClient
        {
            
            [Post("/account/api-keys")]
            [AllowAnyStatusCode]
            Task<Models.AccountApiKey> CreateAsync();
            
            [Delete("/account/api-keys/{api_key_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("api_key_id")] string apiKeyId);
            
            [Get("/account/api-keys/{api_key_id}")]
            [AllowAnyStatusCode]
            Task<Models.AccountApiKey> GetAsync([Path("api_key_id")] string apiKeyId);
            
            [Get("/account/api-keys")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AccountApiKey>> ListAsync();
            
        }
        
    }
}
