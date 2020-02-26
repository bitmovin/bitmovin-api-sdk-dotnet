using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions.Cea708
{
    public class Cea708Api
    {
        private readonly ICea708ApiClient _apiClient;

        public Cea708Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICea708ApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of Cea708Api
        /// </summary>
        public static BitmovinApiBuilder<Cea708Api> Builder => new BitmovinApiBuilder<Cea708Api>();

        /// <summary>
        /// Add CEA 708 Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="cea708CaptionInputStream">The CEA 708 Input Stream to be created</param>
        public async Task<Models.Cea708CaptionInputStream> CreateAsync(string encodingId, Models.Cea708CaptionInputStream cea708CaptionInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, cea708CaptionInputStream);
        }

        /// <summary>
        /// Delete CEA 708 Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the Encoding (required)</param>
        /// <param name="inputStreamId">Id of the CEA 708 input stream. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// CEA 708 Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the CEA 708 input stream. (required)</param>
        public async Task<Models.Cea708CaptionInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List CEA 708 Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Cea708CaptionInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface ICea708ApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/captions/cea708")]
            [AllowAnyStatusCode]
            Task<Models.Cea708CaptionInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Cea708CaptionInputStream cea708CaptionInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/captions/cea708/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/captions/cea708/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.Cea708CaptionInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/captions/cea708")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Cea708CaptionInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
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
