using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea.Srt.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea.Srt
{
    /// <summary>
    /// API for SrtApi
    /// </summary>
    public class SrtApi
    {
        private readonly ISrtApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the SrtApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public SrtApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISrtApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SrtApi
        /// </summary>
        public static BitmovinApiBuilder<SrtApi> Builder => new BitmovinApiBuilder<SrtApi>();

        /// <summary>
        /// Gets the Customdata API
        /// </summary>
        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Embed SRT captions as 608/708 into Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="srtToCea608708Caption">The SRT captions to be embedded as 607/708 into Stream</param>
        public async Task<Models.SrtToCea608708Caption> CreateAsync(string encodingId, string streamId, Models.SrtToCea608708Caption srtToCea608708Caption)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, srtToCea608708Caption);
        }

        /// <summary>
        /// Delete SRT captions as 608/708 from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="captionsId">Id of the caption. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, captionsId);
        }

        /// <summary>
        /// Embed SRT captions as 608/708 Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="captionsId">Id of the caption. (required)</param>
        public async Task<Models.SrtToCea608708Caption> GetAsync(string encodingId, string streamId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, captionsId);
        }

        /// <summary>
        /// List SRT captions as 608/708 from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SrtToCea608708Caption>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface ISrtApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/captions/608-708/srt")]
            [AllowAnyStatusCode]
            Task<Models.SrtToCea608708Caption> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.SrtToCea608708Caption srtToCea608708Caption);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/captions/608-708/srt/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("captions_id")] string captionsId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/captions/608-708/srt/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.SrtToCea608708Caption> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("captions_id")] string captionsId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/captions/608-708/srt")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SrtToCea608708Caption>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
