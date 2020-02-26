using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiMsl.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.AkamaiMsl
{
    public class AkamaiMslApi
    {
        private readonly IAkamaiMslApiClient _apiClient;

        public AkamaiMslApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAkamaiMslApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AkamaiMslApi
        /// </summary>
        public static BitmovinApiBuilder<AkamaiMslApi> Builder => new BitmovinApiBuilder<AkamaiMslApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Akamai MSL Output
        /// </summary>
        /// <param name="akamaiMslOutput">The Akamai MSL output to be created</param>
        public async Task<Models.AkamaiMslOutput> CreateAsync(Models.AkamaiMslOutput akamaiMslOutput)
        {
            return await _apiClient.CreateAsync(akamaiMslOutput);
        }

        /// <summary>
        /// Delete Akamai MSL Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// Akamai MSL Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.AkamaiMslOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List Akamai MSL Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AkamaiMslOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IAkamaiMslApiClient
        {
            [Post("/encoding/outputs/akamai-msl")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiMslOutput> CreateAsync([Body] Models.AkamaiMslOutput akamaiMslOutput);

            [Delete("/encoding/outputs/akamai-msl/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/akamai-msl/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.AkamaiMslOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/akamai-msl")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AkamaiMslOutput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
