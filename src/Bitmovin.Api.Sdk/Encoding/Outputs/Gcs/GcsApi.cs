using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.Gcs.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.Gcs
{
    /// <summary>
    /// API for GcsApi
    /// </summary>
    public class GcsApi
    {
        private readonly IGcsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the GcsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public GcsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IGcsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of GcsApi
        /// </summary>
        public static BitmovinApiBuilder<GcsApi> Builder => new BitmovinApiBuilder<GcsApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create GCS Output
        /// </summary>
        /// <param name="gcsOutput">The GCS output to be created</param>
        public async Task<Models.GcsOutput> CreateAsync(Models.GcsOutput gcsOutput)
        {
            return await _apiClient.CreateAsync(gcsOutput);
        }

        /// <summary>
        /// Delete GCS Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.GcsOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// GCS Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.GcsOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List GCS Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.GcsOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/outputs/gcs")]
            [AllowAnyStatusCode]
            Task<Models.GcsOutput> CreateAsync([Body] Models.GcsOutput gcsOutput);

            [Delete("/encoding/outputs/gcs/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.GcsOutput> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/gcs/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.GcsOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/gcs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.GcsOutput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Filter output by name
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
