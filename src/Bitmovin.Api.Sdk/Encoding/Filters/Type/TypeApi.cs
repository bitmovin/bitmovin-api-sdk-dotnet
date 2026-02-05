using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Type
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
        /// Get Filter Type
        /// </summary>
        /// <param name="filterId">Id of the filter (required)</param>
        public async Task<Models.FilterType> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        internal interface ITypeApiClient
        {
            [Get("/encoding/filters/{filter_id}/type")]
            [AllowAnyStatusCode]
            Task<Models.FilterType> GetAsync([Path("filter_id")] string filterId);
        }
    }
}
