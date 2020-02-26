using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Hdr.DolbyVision
{
    public class DolbyVisionApi
    {
        private readonly IDolbyVisionApiClient _apiClient;

        public DolbyVisionApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDolbyVisionApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DolbyVisionApi
        /// </summary>
        public static BitmovinApiBuilder<DolbyVisionApi> Builder => new BitmovinApiBuilder<DolbyVisionApi>();

        /// <summary>
        /// Add Dolby Vision Metadata
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="dolbyVisionMetadata">The Dolby Vision Metadata to be added</param>
        public async Task<Models.DolbyVisionMetadata> CreateAsync(string encodingId, string streamId, Models.DolbyVisionMetadata dolbyVisionMetadata)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, dolbyVisionMetadata);
        }

        /// <summary>
        /// Delete Dolby Vision Metadata
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="hdrId">Id of the Dolby Vision Metadata. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string hdrId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, hdrId);
        }

        /// <summary>
        /// Dolby Vision Metadata Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="hdrId">Id of the Dolby Vision Metadata. (required)</param>
        public async Task<Models.DolbyVisionMetadata> GetAsync(string encodingId, string streamId, string hdrId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, hdrId);
        }

        /// <summary>
        /// List Dolby Vision Metadata
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DolbyVisionMetadata>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface IDolbyVisionApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/hdr/dolby-vision")]
            [AllowAnyStatusCode]
            Task<Models.DolbyVisionMetadata> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.DolbyVisionMetadata dolbyVisionMetadata);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/hdr/dolby-vision/{hdr_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("hdr_id")] string hdrId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/hdr/dolby-vision/{hdr_id}")]
            [AllowAnyStatusCode]
            Task<Models.DolbyVisionMetadata> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("hdr_id")] string hdrId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/hdr/dolby-vision")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DolbyVisionMetadata>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap] IDictionary<String, Object> queryParams);
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
