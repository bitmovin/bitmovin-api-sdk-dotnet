using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.S3RoleBased.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.S3RoleBased
{
    /// <summary>
    /// API for S3RoleBasedApi
    /// </summary>
    public class S3RoleBasedApi
    {
        private readonly IS3RoleBasedApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the S3RoleBasedApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public S3RoleBasedApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IS3RoleBasedApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of S3RoleBasedApi
        /// </summary>
        public static BitmovinApiBuilder<S3RoleBasedApi> Builder => new BitmovinApiBuilder<S3RoleBasedApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create S3 Role-based Output
        /// </summary>
        /// <param name="s3RoleBasedOutput">The S3 Role-based output to be created  The following permissions are required for S3 Role-based output:  * s3:PutObject  * s3:PutObjectAcl  * s3:ListBucket  * s3:GetBucketLocation </param>
        public async Task<Models.S3RoleBasedOutput> CreateAsync(Models.S3RoleBasedOutput s3RoleBasedOutput)
        {
            return await _apiClient.CreateAsync(s3RoleBasedOutput);
        }

        /// <summary>
        /// Delete S3 Role-based Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.S3RoleBasedOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// S3 Role-based Output Details
        /// </summary>
        /// <param name="outputId">Id of the input (required)</param>
        public async Task<Models.S3RoleBasedOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List S3 Role-based Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.S3RoleBasedOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IS3RoleBasedApiClient
        {
            [Post("/encoding/outputs/s3-role-based")]
            [AllowAnyStatusCode]
            Task<Models.S3RoleBasedOutput> CreateAsync([Body] Models.S3RoleBasedOutput s3RoleBasedOutput);

            [Delete("/encoding/outputs/s3-role-based/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.S3RoleBasedOutput> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/s3-role-based/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.S3RoleBasedOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/s3-role-based")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.S3RoleBasedOutput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
