using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.EbuR128SinglePass.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Filters.EbuR128SinglePass
{
    public class EbuR128SinglePassApi
    {
        private readonly IEbuR128SinglePassApiClient _apiClient;

        public EbuR128SinglePassApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEbuR128SinglePassApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EbuR128SinglePassApi
        /// </summary>
        public static BitmovinApiBuilder<EbuR128SinglePassApi> Builder => new BitmovinApiBuilder<EbuR128SinglePassApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create EBU R128 Single Pass Filter
        /// </summary>
        /// <param name="ebuR128SinglePassFilter">The EBU R128 Single Pass Filter to be created</param>
        public async Task<Models.EbuR128SinglePassFilter> CreateAsync(Models.EbuR128SinglePassFilter ebuR128SinglePassFilter)
        {
            return await _apiClient.CreateAsync(ebuR128SinglePassFilter);
        }

        /// <summary>
        /// Delete EBU R128 Single Pass Filter
        /// </summary>
        /// <param name="filterId">Id of the EBU R128 Single Pass filter. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string filterId)
        {
            return await _apiClient.DeleteAsync(filterId);
        }

        /// <summary>
        /// EBU R128 Single Pass Filter Details
        /// </summary>
        /// <param name="filterId">Id of the EBU R128 Single Pass filter. (required)</param>
        public async Task<Models.EbuR128SinglePassFilter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List EBU R128 Single Pass Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.EbuR128SinglePassFilter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IEbuR128SinglePassApiClient
        {
            [Post("/encoding/filters/ebu-r128-single-pass")]
            [AllowAnyStatusCode]
            Task<Models.EbuR128SinglePassFilter> CreateAsync([Body] Models.EbuR128SinglePassFilter ebuR128SinglePassFilter);

            [Delete("/encoding/filters/ebu-r128-single-pass/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/ebu-r128-single-pass/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.EbuR128SinglePassFilter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters/ebu-r128-single-pass")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.EbuR128SinglePassFilter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
