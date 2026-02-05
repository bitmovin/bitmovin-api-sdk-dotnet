using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Bifs.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Bifs
{
    /// <summary>
    /// API for BifsApi
    /// </summary>
    public class BifsApi
    {
        private readonly IBifsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the BifsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public BifsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IBifsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of BifsApi
        /// </summary>
        public static BitmovinApiBuilder<BifsApi> Builder => new BitmovinApiBuilder<BifsApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add a Roku Bif file
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="bif">The Roku Bif file to be added</param>
        public async Task<Models.Bif> CreateAsync(string encodingId, string streamId, Models.Bif bif)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, bif);
        }

        /// <summary>
        /// Delete Bif
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="bifId">Id of the Bif. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string bifId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, bifId);
        }

        /// <summary>
        /// Bif Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="bifId">Id of the Bif configuration. (required)</param>
        public async Task<Models.Bif> GetAsync(string encodingId, string streamId, string bifId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, bifId);
        }

        /// <summary>
        /// List Bifs
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Bif>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface IBifsApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/bifs")]
            [AllowAnyStatusCode]
            Task<Models.Bif> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.Bif bif);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/bifs/{bif_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("bif_id")] string bifId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/bifs/{bif_id}")]
            [AllowAnyStatusCode]
            Task<Models.Bif> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("bif_id")] string bifId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/bifs")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Bif>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
