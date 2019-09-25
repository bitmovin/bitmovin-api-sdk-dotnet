using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Gce
{
    public class GceApi
    {
        private readonly IGceApiClient _apiClient;

        public GceApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IGceApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of GceApi
        /// </summary>
        public static BitmovinApiBuilder<GceApi> Builder => new BitmovinApiBuilder<GceApi>();

        
        /// <summary>
        /// Add GCE Account
        /// </summary>
        /// <param name="gceAccount">The request payload</param>
        public async Task<Models.GceAccount> CreateAsync(Models.GceAccount gceAccount)
        {
            return await _apiClient.CreateAsync(gceAccount);
        }
        
        /// <summary>
        /// Delete GCE Account
        /// </summary>
        /// <param name="infrastructureId">Id of the GCE account</param>
        public async Task<Models.GceAccount> DeleteAsync(string infrastructureId)
        {
            return await _apiClient.DeleteAsync(infrastructureId);
        }
        
        /// <summary>
        /// GCE Account Details
        /// </summary>
        /// <param name="infrastructureId">Id of the GCE account</param>
        public async Task<Models.GceAccount> GetAsync(string infrastructureId)
        {
            return await _apiClient.GetAsync(infrastructureId);
        }
        
        /// <summary>
        /// List GCE Accounts
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.GceAccount>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface IGceApiClient
        {
            
            [Post("/encoding/infrastructure/gce")]
            [AllowAnyStatusCode]
            Task<Models.GceAccount> CreateAsync([Body] Models.GceAccount gceAccount);
            
            [Delete("/encoding/infrastructure/gce/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.GceAccount> DeleteAsync([Path("infrastructure_id")] string infrastructureId);
            
            [Get("/encoding/infrastructure/gce/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.GceAccount> GetAsync([Path("infrastructure_id")] string infrastructureId);
            
            [Get("/encoding/infrastructure/gce")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.GceAccount>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

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
