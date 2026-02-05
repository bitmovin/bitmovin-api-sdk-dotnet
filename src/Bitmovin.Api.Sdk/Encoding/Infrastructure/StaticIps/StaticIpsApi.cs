using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.StaticIps
{
    /// <summary>
    /// API for StaticIpsApi
    /// </summary>
    public class StaticIpsApi
    {
        private readonly IStaticIpsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the StaticIpsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public StaticIpsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStaticIpsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of StaticIpsApi
        /// </summary>
        public static BitmovinApiBuilder<StaticIpsApi> Builder => new BitmovinApiBuilder<StaticIpsApi>();

        /// <summary>
        /// Add Static IP Address
        /// </summary>
        /// <param name="staticIp">The static ip to be created</param>
        public async Task<Models.StaticIp> CreateAsync(Models.StaticIp staticIp)
        {
            return await _apiClient.CreateAsync(staticIp);
        }

        /// <summary>
        /// Delete Static IP Address
        /// </summary>
        /// <param name="id">Id of the Static IP Address (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string id)
        {
            return await _apiClient.DeleteAsync(id);
        }

        /// <summary>
        /// Static IP Address Details
        /// </summary>
        /// <param name="id">Id of the Static IP Address (required)</param>
        public async Task<Models.StaticIp> GetAsync(string id)
        {
            return await _apiClient.GetAsync(id);
        }

        /// <summary>
        /// List all Static IP Addresses
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.StaticIp>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IStaticIpsApiClient
        {
            [Post("/encoding/infrastructure/static-ips")]
            [AllowAnyStatusCode]
            Task<Models.StaticIp> CreateAsync([Body] Models.StaticIp staticIp);

            [Delete("/encoding/infrastructure/static-ips/{id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("id")] string id);

            [Get("/encoding/infrastructure/static-ips/{id}")]
            [AllowAnyStatusCode]
            Task<Models.StaticIp> GetAsync([Path("id")] string id);

            [Get("/encoding/infrastructure/static-ips")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.StaticIp>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
