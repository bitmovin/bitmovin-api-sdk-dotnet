using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.GenericS3.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.GenericS3
{
    public class GenericS3Api
    {
        private readonly IGenericS3ApiClient _apiClient;

        public GenericS3Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IGenericS3ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of GenericS3Api
        /// </summary>
        public static BitmovinApiBuilder<GenericS3Api> Builder => new BitmovinApiBuilder<GenericS3Api>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Generic S3 Output
        /// </summary>
        /// <param name="genericS3Output">The Generic S3 output to be created</param>
        public async Task<Models.GenericS3Output> CreateAsync(Models.GenericS3Output genericS3Output)
        {
            return await _apiClient.CreateAsync(genericS3Output);
        }

        /// <summary>
        /// Delete Generic S3 Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.GenericS3Output> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// Generic S3 Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.GenericS3Output> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List Generic S3 Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.GenericS3Output>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IGenericS3ApiClient
        {
            [Post("/encoding/outputs/generic-s3")]
            [AllowAnyStatusCode]
            Task<Models.GenericS3Output> CreateAsync([Body] Models.GenericS3Output genericS3Output);

            [Delete("/encoding/outputs/generic-s3/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.GenericS3Output> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/generic-s3/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.GenericS3Output> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/generic-s3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.GenericS3Output>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
