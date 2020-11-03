using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Srt.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Srt
{
    public class SrtApi
    {
        private readonly ISrtApiClient _apiClient;

        public SrtApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISrtApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SrtApi
        /// </summary>
        public static BitmovinApiBuilder<SrtApi> Builder => new BitmovinApiBuilder<SrtApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create SRT input
        /// </summary>
        /// <param name="srtInput">The SrtInput to be created</param>
        public async Task<Models.SrtInput> CreateAsync(Models.SrtInput srtInput)
        {
            return await _apiClient.CreateAsync(srtInput);
        }

        /// <summary>
        /// Delete SRT input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.SrtInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// SRT Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.SrtInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List SRT inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SrtInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface ISrtApiClient
        {
            [Post("/encoding/inputs/srt")]
            [AllowAnyStatusCode]
            Task<Models.SrtInput> CreateAsync([Body] Models.SrtInput srtInput);

            [Delete("/encoding/inputs/srt/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.SrtInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/srt/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.SrtInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/srt")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SrtInput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Filter inputs by name
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
