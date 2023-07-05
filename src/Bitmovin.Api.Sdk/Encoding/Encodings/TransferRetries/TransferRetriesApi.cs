using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.TransferRetries
{
    public class TransferRetriesApi
    {
        private readonly ITransferRetriesApiClient _apiClient;

        public TransferRetriesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITransferRetriesApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of TransferRetriesApi
        /// </summary>
        public static BitmovinApiBuilder<TransferRetriesApi> Builder => new BitmovinApiBuilder<TransferRetriesApi>();

        /// <summary>
        /// Transfer retry
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.TransferRetry> CreateAsync(string encodingId)
        {
            return await _apiClient.CreateAsync(encodingId);
        }

        /// <summary>
        /// Transfer retry Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="transferRetryId">Id of the transfer-retry. (required)</param>
        public async Task<Models.TransferRetry> GetAsync(string encodingId, string transferRetryId)
        {
            return await _apiClient.GetAsync(encodingId, transferRetryId);
        }

        /// <summary>
        /// List transfer-retries
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TransferRetry>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface ITransferRetriesApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/transfer-retries")]
            [AllowAnyStatusCode]
            Task<Models.TransferRetry> CreateAsync([Path("encoding_id")] string encodingId);

            [Get("/encoding/encodings/{encoding_id}/transfer-retries/{transfer_retry_id}")]
            [AllowAnyStatusCode]
            Task<Models.TransferRetry> GetAsync([Path("encoding_id")] string encodingId, [Path("transfer_retry_id")] string transferRetryId);

            [Get("/encoding/encodings/{encoding_id}/transfer-retries")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TransferRetry>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
