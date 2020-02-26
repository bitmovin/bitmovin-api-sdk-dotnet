using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Text.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Text
{
    public class TextApi
    {
        private readonly ITextApiClient _apiClient;

        public TextApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITextApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of TextApi
        /// </summary>
        public static BitmovinApiBuilder<TextApi> Builder => new BitmovinApiBuilder<TextApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Text Filter
        /// </summary>
        /// <param name="textFilter">The Text Filter to be created</param>
        public async Task<Models.TextFilter> CreateAsync(Models.TextFilter textFilter)
        {
            return await _apiClient.CreateAsync(textFilter);
        }

        /// <summary>
        /// Delete Text Filter
        /// </summary>
        /// <param name="filterId">Id of the Text Filter (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// Text Filter Details
        /// </summary>
        /// <param name="filterId">Id of the Text Filter (required)</param>
        public async Task<Models.TextFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List Text Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TextFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface ITextApiClient
        {
            [Post("/encoding/filters/text")]
            [AllowAnyStatusCode]
            Task<Models.TextFilter> CreateAsync([Body] Models.TextFilter textFilter);

            [Delete("/encoding/filters/text/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/text/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.TextFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/text")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TextFilter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
