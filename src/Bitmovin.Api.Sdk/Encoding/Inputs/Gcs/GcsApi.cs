using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.Gcs.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Gcs
{
    public class GcsApi
    {
        private readonly IGcsApiClient _apiClient;

        public GcsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IGcsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of GcsApi
        /// </summary>
        public static BitmovinApiBuilder<GcsApi> Builder => new BitmovinApiBuilder<GcsApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create GCS Input
        /// </summary>
        /// <param name="gcsInput">The GcsInput to be created</param>
        public async Task<Models.GcsInput> CreateAsync(Models.GcsInput gcsInput)
        {
            return await _apiClient.CreateAsync(gcsInput);
        }

        /// <summary>
        /// Delete GCS Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.GcsInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// GCS Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.GcsInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List GCS Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.GcsInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IGcsApiClient
        {
            [Post("/encoding/inputs/gcs")]
            [AllowAnyStatusCode]
            Task<Models.GcsInput> CreateAsync([Body] Models.GcsInput gcsInput);

            [Delete("/encoding/inputs/gcs/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.GcsInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/gcs/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.GcsInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/gcs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.GcsInput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
