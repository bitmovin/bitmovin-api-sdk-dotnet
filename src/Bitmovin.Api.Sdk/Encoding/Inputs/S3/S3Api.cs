using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.S3.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.S3
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
        /// Create S3 Input
        /// </summary>
        /// <param name="s3Input">The S3 input to be created  The following permissions are required for S3 input:   * s3:GetObject   * s3:GetBucketLocation, </param>
        public async Task<Models.S3Input> CreateAsync(Models.S3Input s3Input)
        {
            return await _apiClient.CreateAsync(s3Input);
        }

        /// <summary>
        /// Delete S3 Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// S3 Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.S3Input> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List S3 Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.S3Input>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/inputs/s3")]
            [AllowAnyStatusCode]
            Task<Models.S3Input> CreateAsync([Body] Models.S3Input s3Input);

            [Delete("/encoding/inputs/s3/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/s3/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.S3Input> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/s3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.S3Input>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
