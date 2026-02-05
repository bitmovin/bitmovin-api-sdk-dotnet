using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Crop.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Crop
{
    /// <summary>
    /// API for CropApi
    /// </summary>
    public class CropApi
    {
        private readonly ICropApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the CropApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public CropApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICropApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CropApi
        /// </summary>
        public static BitmovinApiBuilder<CropApi> Builder => new BitmovinApiBuilder<CropApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Crop Filter
        /// </summary>
        /// <param name="cropFilter">The Crop Filter to be created</param>
        public async Task<Models.CropFilter> CreateAsync(Models.CropFilter cropFilter)
        {
            return await _apiClient.CreateAsync(cropFilter);
        }

        /// <summary>
        /// Delete Crop Filter
        /// </summary>
        /// <param name="filterId">Id of the Crop Filter. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Crop Filter Details
        /// </summary>
        /// <param name="filterId">Id of the Crop Filter. (required)</param>
        public async Task<Models.CropFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Crop Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CropFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface ICropApiClient
        {
            [Post("/encoding/filters/crop")]
            [AllowAnyStatusCode]
            Task<Models.CropFilter> CreateAsync([Body] Models.CropFilter cropFilter);

            [Delete("/encoding/filters/crop/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/crop/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.CropFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/crop")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CropFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
