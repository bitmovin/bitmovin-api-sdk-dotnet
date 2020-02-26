using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Sidecar.DolbyVisionMetadataIngest
{
    public class DolbyVisionMetadataIngestApi
    {
        private readonly IDolbyVisionMetadataIngestApiClient _apiClient;

        public DolbyVisionMetadataIngestApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDolbyVisionMetadataIngestApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DolbyVisionMetadataIngestApi
        /// </summary>
        public static BitmovinApiBuilder<DolbyVisionMetadataIngestApi> Builder => new BitmovinApiBuilder<DolbyVisionMetadataIngestApi>();

        /// <summary>
        /// Add Dolby Vision Metadata Ingest Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="dolbyVisionMetadataIngestInputStream">The Dolby Vision Metadata Ingest Input Stream to be created</param>
        public async Task<Models.DolbyVisionMetadataIngestInputStream> CreateAsync(string encodingId, Models.DolbyVisionMetadataIngestInputStream dolbyVisionMetadataIngestInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, dolbyVisionMetadataIngestInputStream);
        }

        /// <summary>
        /// Delete Dolby Vision Metadata Ingest Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the Dolby Vision Metadata Ingest input stream. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// Dolby Vision Metadata Ingest Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the Dolby Vision Metadata Ingest input stream. (required)</param>
        public async Task<Models.DolbyVisionMetadataIngestInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List Dolby Vision Metadata Ingest Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DolbyVisionMetadataIngestInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IDolbyVisionMetadataIngestApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/sidecar/dolby-vision-metadata-ingest")]
            [AllowAnyStatusCode]
            Task<Models.DolbyVisionMetadataIngestInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.DolbyVisionMetadataIngestInputStream dolbyVisionMetadataIngestInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/sidecar/dolby-vision-metadata-ingest/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/sidecar/dolby-vision-metadata-ingest/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.DolbyVisionMetadataIngestInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/sidecar/dolby-vision-metadata-ingest")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DolbyVisionMetadataIngestInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
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
