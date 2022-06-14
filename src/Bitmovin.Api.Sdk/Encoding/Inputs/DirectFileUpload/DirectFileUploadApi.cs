using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.DirectFileUpload.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.DirectFileUpload
{
    public class DirectFileUploadApi
    {
        private readonly IDirectFileUploadApiClient _apiClient;

        public DirectFileUploadApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDirectFileUploadApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DirectFileUploadApi
        /// </summary>
        public static BitmovinApiBuilder<DirectFileUploadApi> Builder => new BitmovinApiBuilder<DirectFileUploadApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Direct File Upload Input
        /// </summary>
        /// <param name="directFileUploadInput">The Direct File Upload input to be created</param>
        public async Task<Models.DirectFileUploadInput> CreateAsync(Models.DirectFileUploadInput directFileUploadInput)
        {
            return await _apiClient.CreateAsync(directFileUploadInput);
        }

        /// <summary>
        /// Delete Direct File Upload Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// Direct File Upload Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.DirectFileUploadInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List Direct File Upload Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DirectFileUploadInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IDirectFileUploadApiClient
        {
            [Post("/encoding/inputs/direct-file-upload")]
            [AllowAnyStatusCode]
            Task<Models.DirectFileUploadInput> CreateAsync([Body] Models.DirectFileUploadInput directFileUploadInput);

            [Delete("/encoding/inputs/direct-file-upload/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/direct-file-upload/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.DirectFileUploadInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/direct-file-upload")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DirectFileUploadInput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
