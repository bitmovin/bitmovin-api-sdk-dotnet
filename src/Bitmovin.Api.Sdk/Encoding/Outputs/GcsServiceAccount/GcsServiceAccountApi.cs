using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.GcsServiceAccount.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.GcsServiceAccount
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
        /// Create Service Account based GCS Output
        /// </summary>
        /// <param name="gcsServiceAccountOutput">The GCS output to be created</param>
        public async Task<Models.GcsServiceAccountOutput> CreateAsync(Models.GcsServiceAccountOutput gcsServiceAccountOutput)
        {
            return await _apiClient.CreateAsync(gcsServiceAccountOutput);
        }

        /// <summary>
        /// Delete Service Account based GCS Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.GcsServiceAccountOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// Service Account based GCS Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.GcsServiceAccountOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List Service Account based GCS Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.GcsServiceAccountOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
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
            [Post("/encoding/outputs/gcs-service-account")]
            [AllowAnyStatusCode]
            Task<Models.GcsServiceAccountOutput> CreateAsync([Body] Models.GcsServiceAccountOutput gcsServiceAccountOutput);

            [Delete("/encoding/outputs/gcs-service-account/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.GcsServiceAccountOutput> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/gcs-service-account/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.GcsServiceAccountOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/gcs-service-account")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.GcsServiceAccountOutput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
