using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Rotate.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Rotate
{
    public class RotateApi
    {
        private readonly IRotateApiClient _apiClient;

        public RotateApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IRotateApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of RotateApi
        /// </summary>
        public static BitmovinApiBuilder<RotateApi> Builder => new BitmovinApiBuilder<RotateApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Rotate Filter
        /// </summary>
        /// <param name="rotateFilter">The Rotate Filter to be created</param>
        public async Task<Models.RotateFilter> CreateAsync(Models.RotateFilter rotateFilter)
        {
            return await _apiClient.CreateAsync(rotateFilter);
        }

        /// <summary>
        /// Delete Rotate Filter
        /// </summary>
        /// <param name="filterId">Id of the Rotate configuration. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Rotate Filter Details
        /// </summary>
        /// <param name="filterId">Id of the Rotate configuration. (required)</param>
        public async Task<Models.RotateFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Rotate Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.RotateFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IRotateApiClient
        {
            [Post("/encoding/filters/rotate")]
            [AllowAnyStatusCode]
            Task<Models.RotateFilter> CreateAsync([Body] Models.RotateFilter rotateFilter);

            [Delete("/encoding/filters/rotate/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/rotate/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.RotateFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/rotate")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.RotateFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
