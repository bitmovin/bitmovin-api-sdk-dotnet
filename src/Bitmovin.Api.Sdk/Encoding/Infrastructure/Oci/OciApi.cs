using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Infrastructure.Oci.Regions;

namespace Bitmovin.Api.Sdk.Encoding.Infrastructure.Oci
{
    public class OciApi
    {
        private readonly IOciApiClient _apiClient;

        public OciApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IOciApiClient>();
            Regions = new RegionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of OciApi
        /// </summary>
        public static BitmovinApiBuilder<OciApi> Builder => new BitmovinApiBuilder<OciApi>();

        public RegionsApi Regions { get; }

        /// <summary>
        /// Add OCI account
        /// </summary>
        /// <param name="ociAccount">The OCI account to be added</param>
        public async Task<Models.OciAccount> CreateAsync(Models.OciAccount ociAccount)
        {
            return await _apiClient.CreateAsync(ociAccount);
        }

        /// <summary>
        /// Delete OCI account
        /// </summary>
        /// <param name="infrastructureId">Id of the OCI account (required)</param>
        public async Task<Models.OciAccount> DeleteAsync(string infrastructureId)
        {
            return await _apiClient.DeleteAsync(infrastructureId);
        }

        /// <summary>
        /// OCI account details
        /// </summary>
        /// <param name="infrastructureId">Id of the OCI account (required)</param>
        public async Task<Models.OciAccount> GetAsync(string infrastructureId)
        {
            return await _apiClient.GetAsync(infrastructureId);
        }

        /// <summary>
        /// List OCI accounts
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.OciAccount>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IOciApiClient
        {
            [Post("/encoding/infrastructure/oci")]
            [AllowAnyStatusCode]
            Task<Models.OciAccount> CreateAsync([Body] Models.OciAccount ociAccount);

            [Delete("/encoding/infrastructure/oci/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.OciAccount> DeleteAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/oci/{infrastructure_id}")]
            [AllowAnyStatusCode]
            Task<Models.OciAccount> GetAsync([Path("infrastructure_id")] string infrastructureId);

            [Get("/encoding/infrastructure/oci")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.OciAccount>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

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
