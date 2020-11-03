using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.DenoiseHqdn3d.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.DenoiseHqdn3d
{
    public class DenoiseHqdn3dApi
    {
        private readonly IDenoiseHqdn3dApiClient _apiClient;

        public DenoiseHqdn3dApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDenoiseHqdn3dApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DenoiseHqdn3dApi
        /// </summary>
        public static BitmovinApiBuilder<DenoiseHqdn3dApi> Builder => new BitmovinApiBuilder<DenoiseHqdn3dApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Denoise hqdn3d Filter
        /// </summary>
        /// <param name="denoiseHqdn3dFilter">The Denoise hqdn3d Filter to be created</param>
        public async Task<Models.DenoiseHqdn3dFilter> CreateAsync(Models.DenoiseHqdn3dFilter denoiseHqdn3dFilter)
        {
            return await _apiClient.CreateAsync(denoiseHqdn3dFilter);
        }

        /// <summary>
        /// Delete Denoise hqdn3d Filter
        /// </summary>
        /// <param name="filterId">Id of the denoise hqdn3d filter (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Denoise hqdn3d Filter Details
        /// </summary>
        /// <param name="filterId">Id of the denoise hqdn3d filter (required)</param>
        public async Task<Models.DenoiseHqdn3dFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Denoise hqdn3d Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DenoiseHqdn3dFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDenoiseHqdn3dApiClient
        {
            [Post("/encoding/filters/denoise-hqdn3d")]
            [AllowAnyStatusCode]
            Task<Models.DenoiseHqdn3dFilter> CreateAsync([Body] Models.DenoiseHqdn3dFilter denoiseHqdn3dFilter);

            [Delete("/encoding/filters/denoise-hqdn3d/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/denoise-hqdn3d/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.DenoiseHqdn3dFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/denoise-hqdn3d")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DenoiseHqdn3dFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

            /// <summary>
            /// Filter filters by name
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

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
