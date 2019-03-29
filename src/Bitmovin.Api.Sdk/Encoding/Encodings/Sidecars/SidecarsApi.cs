using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars
{
    public class SidecarsApi
    {
        private readonly ISidecarsApiClient _apiClient;

        public SidecarsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISidecarsApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SidecarsApi
        /// </summary>
        public static BitmovinApiBuilder<SidecarsApi> Builder => new BitmovinApiBuilder<SidecarsApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Add Sidecar
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="sidecarFile">The request payload</param>
        public async Task<Models.SidecarFile> CreateAsync(string encodingId, Models.SidecarFile sidecarFile)
        {
            return await _apiClient.CreateAsync(encodingId, sidecarFile);
        }
        
        /// <summary>
        /// Delete Sidecar
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="sidecarId">Id of the sidecar.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string sidecarId)
        {
            return await _apiClient.DeleteAsync(encodingId, sidecarId);
        }
        
        /// <summary>
        /// Sidecar Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="sidecarId">Id of the sidecar.</param>
        public async Task<Models.SidecarFile> GetAsync(string encodingId, string sidecarId)
        {
            return await _apiClient.GetAsync(encodingId, sidecarId);
        }
        
        /// <summary>
        /// List Sidecars
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SidecarFile>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface ISidecarsApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/sidecars")]
            [AllowAnyStatusCode]
            Task<Models.SidecarFile> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.SidecarFile sidecarFile);
            
            [Delete("/encoding/encodings/{encoding_id}/sidecars/{sidecar_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);
            
            [Get("/encoding/encodings/{encoding_id}/sidecars/{sidecar_id}")]
            [AllowAnyStatusCode]
            Task<Models.SidecarFile> GetAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);
            
            [Get("/encoding/encodings/{encoding_id}/sidecars")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SidecarFile>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
