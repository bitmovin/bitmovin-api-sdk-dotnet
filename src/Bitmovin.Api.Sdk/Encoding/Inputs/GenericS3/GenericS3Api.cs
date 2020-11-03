using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.GenericS3.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.GenericS3
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
        /// Create Generic S3 Input
        /// </summary>
        /// <param name="genericS3Input">The GenericS3 input to be created</param>
        public async Task<Models.GenericS3Input> CreateAsync(Models.GenericS3Input genericS3Input)
        {
            return await _apiClient.CreateAsync(genericS3Input);
        }

        /// <summary>
        /// Delete Generic S3 Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.GenericS3Input> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// Generic S3 Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.GenericS3Input> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List Generic S3 Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.GenericS3Input>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/inputs/generic-s3")]
            [AllowAnyStatusCode]
            Task<Models.GenericS3Input> CreateAsync([Body] Models.GenericS3Input genericS3Input);

            [Delete("/encoding/inputs/generic-s3/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.GenericS3Input> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/generic-s3/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.GenericS3Input> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/generic-s3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.GenericS3Input>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
