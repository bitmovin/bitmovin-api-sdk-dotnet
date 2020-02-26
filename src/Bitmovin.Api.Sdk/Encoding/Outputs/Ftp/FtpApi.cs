using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Outputs.Ftp.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Outputs.Ftp
{
    public class FtpApi
    {
        private readonly IFtpApiClient _apiClient;

        public FtpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFtpApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of FtpApi
        /// </summary>
        public static BitmovinApiBuilder<FtpApi> Builder => new BitmovinApiBuilder<FtpApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Create FTP Output
        /// </summary>
        /// <param name="ftpOutput">The FTP output to be created</param>
        public async Task<Models.FtpOutput> CreateAsync(Models.FtpOutput ftpOutput)
        {
            return await _apiClient.CreateAsync(ftpOutput);
        }

        /// <summary>
        /// Delete FTP Output
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.FtpOutput> DeleteAsync(string outputId)
        {
            return await _apiClient.DeleteAsync(outputId);
        }

        /// <summary>
        /// FTP Output Details
        /// </summary>
        /// <param name="outputId">Id of the output (required)</param>
        public async Task<Models.FtpOutput> GetAsync(string outputId)
        {
            return await _apiClient.GetAsync(outputId);
        }

        /// <summary>
        /// List FTP Outputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.FtpOutput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IFtpApiClient
        {
            [Post("/encoding/outputs/ftp")]
            [AllowAnyStatusCode]
            Task<Models.FtpOutput> CreateAsync([Body] Models.FtpOutput ftpOutput);

            [Delete("/encoding/outputs/ftp/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.FtpOutput> DeleteAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/ftp/{output_id}")]
            [AllowAnyStatusCode]
            Task<Models.FtpOutput> GetAsync([Path("output_id")] string outputId);

            [Get("/encoding/outputs/ftp")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.FtpOutput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
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
