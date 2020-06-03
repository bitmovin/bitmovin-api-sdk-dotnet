using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.S3.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.S3
{
    public class S3Api
    {
        private readonly IS3ApiClient _apiClient;

        public S3Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IS3ApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of S3Api
        /// </summary>
        public static BitmovinApiBuilder<S3Api> Builder => new BitmovinApiBuilder<S3Api>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create S3 Output
        /// </summary>
        /// <param name="s3Output">The S3 output to be created  The following permissions are required for S3 output:  * s3:PutObject  * s3:PutObjectAcl  * s3:ListBucket  * s3:GetBucketLocation </param>
        public async Task<Models.S3Output> CreateAsync(Models.S3Output s3Output)
        {
            return await _apiClient.CreateAsync(s3Output);
        }

        /// <summary>
        /// Delete S3 Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.S3Output> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// S3 Output Details
        /// </summary>
        /// <param name="outputId">Id of the input (required)</param>
        public async Task<Models.S3Output> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List S3 Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.S3Output>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IS3ApiClient
        {
            [Post("/encoding/outputs/s3")]
            [AllowAnyStatusCode]
            Task<Models.S3Output> CreateAsync([Body] Models.S3Output s3Output);

            [Delete("/encoding/outputs/s3/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.S3Output> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/s3/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.S3Output> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/s3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.S3Output>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
