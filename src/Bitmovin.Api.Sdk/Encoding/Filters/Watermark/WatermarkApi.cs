using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Watermark.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Watermark
{
    public class WatermarkApi
    {
        private readonly IWatermarkApiClient _apiClient;

        public WatermarkApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWatermarkApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of WatermarkApi
        /// </summary>
        public static BitmovinApiBuilder<WatermarkApi> Builder => new BitmovinApiBuilder<WatermarkApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Watermark Filter
        /// </summary>
        /// <param name="watermarkFilter">The Watermark Filter to be created. Only one horizontal and one vertical distance parameter is allowed, either top or bottom, and either left or right. See example body.</param>
        public async Task<Models.WatermarkFilter> CreateAsync(Models.WatermarkFilter watermarkFilter)
        {
            return await _apiClient.CreateAsync(watermarkFilter);
        }

        /// <summary>
        /// Delete Watermark Filter
        /// </summary>
        /// <param name="filterId">Id of the Watermark Filter. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Watermark Filter Details
        /// </summary>
        /// <param name="filterId">Id of the Watermark Filter. (required)</param>
        public async Task<Models.WatermarkFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Watermark Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.WatermarkFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IWatermarkApiClient
        {
            [Post("/encoding/filters/watermark")]
            [AllowAnyStatusCode]
            Task<Models.WatermarkFilter> CreateAsync([Body] Models.WatermarkFilter watermarkFilter);

            [Delete("/encoding/filters/watermark/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/watermark/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.WatermarkFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/watermark")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.WatermarkFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
