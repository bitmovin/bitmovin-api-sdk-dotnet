using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Akamai.Regions;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Akamai
{
    /// <summary>
    /// API for AkamaiApi
    /// </summary>
    public class AkamaiApi
    {
        private readonly IAkamaiApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AkamaiApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AkamaiApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAkamaiApiClient>();
            Regions = new RegionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AkamaiApi
        /// </summary>
        public static BitmovinApiBuilder<AkamaiApi> Builder => new BitmovinApiBuilder<AkamaiApi>();

        /// <summary>
        /// Gets the Regions API
        /// </summary>
        public RegionsApi Regions { get; }

        /// <summary>
        /// Add Akamai account
        /// </summary>
        /// <param name="akamaiAccount">The Akamai account to be added</param>
        public async Task<Models.AkamaiAccount> CreateAsync(Models.AkamaiAccount akamaiAccount)
        {
            return await _apiClient.CreateAsync(akamaiAccount);
        }

        /// <summary>
        /// Delete Akamai account
        /// </summary>
        /// <param name="infrastructureId">Id of the Akamai account (required)</param>
        public async Task<Models.AkamaiAccount> DeleteAsync(string infrastructureId)
        {
            return await _apiClient.DeleteAsync(infrastructureId);
        }

        /// <summary>
        /// Akamai account details
        /// </summary>
        /// <param name="infrastructureId">Id of the Akamai account (required)</param>
        public async Task<Models.AkamaiAccount> GetAsync(string infrastructureId)
        {
            return await _apiClient.GetAsync(infrastructureId);
        }

        /// <summary>
        /// List Akamai accounts
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AkamaiAccount>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAkamaiApiClient
        {
            [Post("/encoding/infrastructure/akamai")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiAccount> CreateAsync([Body] Models.AkamaiAccount akamaiAccount);

            [Delete("/encoding/infrastructure/akamai/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiAccount> DeleteAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/akamai/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiAccount> GetAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/akamai")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AkamaiAccount>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
