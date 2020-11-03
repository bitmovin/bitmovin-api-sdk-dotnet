using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Thumbnails.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Thumbnails
{
    public class ThumbnailsApi
    {
        private readonly IThumbnailsApiClient _apiClient;

        public ThumbnailsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IThumbnailsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ThumbnailsApi
        /// </summary>
        public static BitmovinApiBuilder<ThumbnailsApi> Builder => new BitmovinApiBuilder<ThumbnailsApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add Thumbnail
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="thumbnail">The Thumbnail to be added</param>
        public async Task<Models.Thumbnail> CreateAsync(string encodingId, string streamId, Models.Thumbnail thumbnail)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, thumbnail);
        }

        /// <summary>
        /// Delete Thumbnail
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="thumbnailId">Id of the thumbnail. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string thumbnailId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, thumbnailId);
        }

        /// <summary>
        /// Thumbnail Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="thumbnailId">Id of the thumbnail. (required)</param>
        public async Task<Models.Thumbnail> GetAsync(string encodingId, string streamId, string thumbnailId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, thumbnailId);
        }

        /// <summary>
        /// List Thumbnails
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Thumbnail>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface IThumbnailsApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/thumbnails")]
            [AllowAnyStatusCode]
            Task<Models.Thumbnail> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.Thumbnail thumbnail);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/thumbnails/{thumbnail_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("thumbnail_id")] string thumbnailId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/thumbnails/{thumbnail_id}")]
            [AllowAnyStatusCode]
            Task<Models.Thumbnail> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("thumbnail_id")] string thumbnailId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/thumbnails")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Thumbnail>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
