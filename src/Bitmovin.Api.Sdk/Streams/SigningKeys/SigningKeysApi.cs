using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Streams.SigningKeys
{
    public class SigningKeysApi
    {
        private readonly ISigningKeysApiClient _apiClient;

        public SigningKeysApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISigningKeysApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of SigningKeysApi
        /// </summary>
        public static BitmovinApiBuilder<SigningKeysApi> Builder => new BitmovinApiBuilder<SigningKeysApi>();

        /// <summary>
        /// Create new signing-key
        /// </summary>
        public async Task<Models.StreamsSigningKeyResponse> CreateAsync()
        {
            return await _apiClient.CreateAsync();
        }

        /// <summary>
        /// Delete signing-key
        /// </summary>
        /// <param name="keyId">Id of the signing key. (required)</param>
        public async Task DeleteAsync(string keyId)
        {
            await _apiClient.DeleteAsync(keyId);
        }

        /// <summary>
        /// Get list of public signing key ids
        /// </summary>
        public async Task<Models.StreamsPublicSigningKeyResponse> GetAsync()
        {
            return await _apiClient.GetAsync();
        }

        internal interface ISigningKeysApiClient
        {
            [Post("/streams/signing-keys")]
            [AllowAnyStatusCode]
            Task<Models.StreamsSigningKeyResponse> CreateAsync();

            [Delete("/streams/signing-keys/{key_id}")]
            [AllowAnyStatusCode]
            Task DeleteAsync([Path("key_id")] string keyId);

            [Get("/streams/signing-keys")]
            [AllowAnyStatusCode]
            Task<Models.StreamsPublicSigningKeyResponse> GetAsync();
        }
    }
}
