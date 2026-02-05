using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Ingest
{
    /// <summary>
    /// API for IngestApi
    /// </summary>
    public class IngestApi
    {
        private readonly IIngestApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the IngestApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public IngestApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IIngestApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of IngestApi
        /// </summary>
        public static BitmovinApiBuilder<IngestApi> Builder => new BitmovinApiBuilder<IngestApi>();

        /// <summary>
        /// Add Ingest Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="ingestInputStream">The Ingest Input Stream to be created</param>
        public async Task<Models.IngestInputStream> CreateAsync(string encodingId, Models.IngestInputStream ingestInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, ingestInputStream);
        }

        /// <summary>
        /// Delete Ingest Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the ingest input stream. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// Ingest Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the ingest input stream. (required)</param>
        public async Task<Models.IngestInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List Ingest Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.IngestInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IIngestApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/ingest")]
            [AllowAnyStatusCode]
            Task<Models.IngestInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.IngestInputStream ingestInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/ingest/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/ingest/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.IngestInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/ingest")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.IngestInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
