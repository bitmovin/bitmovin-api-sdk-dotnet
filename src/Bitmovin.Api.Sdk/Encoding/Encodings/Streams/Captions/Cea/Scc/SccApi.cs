using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea.Scc.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Captions.Cea.Scc
{
    public class SccApi
    {
        private readonly ISccApiClient _apiClient;

        public SccApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ISccApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of SccApi
        /// </summary>
        public static BitmovinApiBuilder<SccApi> Builder => new BitmovinApiBuilder<SccApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Embed SCC captions as 608/708 into Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="sccCaption">The SCC captions to be embedded as 607/708 into Stream</param>
        public async Task<Models.SccCaption> CreateAsync(string encodingId, string streamId, Models.SccCaption sccCaption)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, sccCaption);
        }

        /// <summary>
        /// Delete SCC captions as 608/708 from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="captionsId">Id of the caption. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, captionsId);
        }

        /// <summary>
        /// Embed SCC captions as 608/708 Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="captionsId">Id of the caption. (required)</param>
        public async Task<Models.SccCaption> GetAsync(string encodingId, string streamId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, captionsId);
        }

        /// <summary>
        /// List SCC captions as 608/708 from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SccCaption>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface ISccApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/captions/608-708/scc")]
            [AllowAnyStatusCode]
            Task<Models.SccCaption> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.SccCaption sccCaption);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/captions/608-708/scc/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("captions_id")] string captionsId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/captions/608-708/scc/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.SccCaption> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("captions_id")] string captionsId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/captions/608-708/scc")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SccCaption>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap] IDictionary<String, Object> queryParams);
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
