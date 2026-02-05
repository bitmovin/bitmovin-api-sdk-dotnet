using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Type
{
    /// <summary>
    /// API for TypeApi
    /// </summary>
    public class TypeApi
    {
        private readonly ITypeApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the TypeApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public TypeApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITypeApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TypeApi
        /// </summary>
        public static BitmovinApiBuilder<TypeApi> Builder => new BitmovinApiBuilder<TypeApi>();

        /// <summary>
        /// Get Input Type
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.InputTypeResponse> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        internal interface ITypeApiClient
        {
            [Get("/encoding/inputs/{input_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.InputTypeResponse> GetAsync([Path("input_id")] string inputId);
        }
    }
}
