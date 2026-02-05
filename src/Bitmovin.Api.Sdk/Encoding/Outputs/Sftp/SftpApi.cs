using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.Sftp.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.Sftp
{
    /// <summary>
    /// API for SftpApi
    /// </summary>
    public class SftpApi
    {
        private readonly ISftpApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SftpApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SftpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISftpApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SftpApi
        /// </summary>
        public static BitmovinApiBuilder<SftpApi> Builder => new BitmovinApiBuilder<SftpApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create SFTP Output
        /// </summary>
        /// <param name="sftpOutput">The SFTP output to be created.</param>
        public async Task<Models.SftpOutput> CreateAsync(Models.SftpOutput sftpOutput)
        {
            return await _apiClient.CreateAsync(sftpOutput);
        }

        /// <summary>
        /// Delete SFTP Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.SftpOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// SFTP Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.SftpOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List SFTP Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SftpOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface ISftpApiClient
        {
            [Post("/encoding/outputs/sftp")]
            [AllowAnyStatusCode]
            Task<Models.SftpOutput> CreateAsync([Body] Models.SftpOutput sftpOutput);

            [Delete("/encoding/outputs/sftp/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.SftpOutput> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/sftp/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.SftpOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/sftp")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SftpOutput>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
