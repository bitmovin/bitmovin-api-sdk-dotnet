using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Inputs.GcsServiceAccount.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.GcsServiceAccount
{
    public class GcsServiceAccountApi
    {
        private readonly IGcsServiceAccountApiClient _apiClient;

        public GcsServiceAccountApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IGcsServiceAccountApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of GcsServiceAccountApi
        /// </summary>
        public static BitmovinApiBuilder<GcsServiceAccountApi> Builder => new BitmovinApiBuilder<GcsServiceAccountApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create Service Account based GCS Input
        /// </summary>
        /// <param name="gcsServiceAccountInput">The GcsInput to be created</param>
        public async Task<Models.GcsServiceAccountInput> CreateAsync(Models.GcsServiceAccountInput gcsServiceAccountInput)
        {
            return await _apiClient.CreateAsync(gcsServiceAccountInput);
        }

        /// <summary>
        /// Delete Service Account based GCS Input
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.GcsServiceAccountInput> DeleteAsync(string inputId)
        {
            return await _apiClient.DeleteAsync(inputId);
        }

        /// <summary>
        /// List Service Account based GCS Input Details
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.GcsServiceAccountInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        /// <summary>
        /// List Service Account based GCS Inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.GcsServiceAccountInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IGcsServiceAccountApiClient
        {
            [Post("/encoding/inputs/gcs-service-account")]
            [AllowAnyStatusCode]
            Task<Models.GcsServiceAccountInput> CreateAsync([Body] Models.GcsServiceAccountInput gcsServiceAccountInput);

            [Delete("/encoding/inputs/gcs-service-account/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.GcsServiceAccountInput> DeleteAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/gcs-service-account/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.GcsServiceAccountInput> GetAsync([Path("input_id")] string inputId);

            [Get("/encoding/inputs/gcs-service-account")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.GcsServiceAccountInput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
