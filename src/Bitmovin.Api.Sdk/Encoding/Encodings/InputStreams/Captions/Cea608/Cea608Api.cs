using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Captions.Cea608
{
    public class Cea608Api
    {
        private readonly ICea608ApiClient _apiClient;

        public Cea608Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICea608ApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of Cea608Api
        /// </summary>
        public static BitmovinApiBuilder<Cea608Api> Builder => new BitmovinApiBuilder<Cea608Api>();

        /// <summary>
        /// Add CEA 608 Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="cea608CaptionInputStream">The CEA 608 Input Stream to be created</param>
        public async Task<Models.Cea608CaptionInputStream> CreateAsync(string encodingId, Models.Cea608CaptionInputStream cea608CaptionInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, cea608CaptionInputStream);
        }

        /// <summary>
        /// Delete CEA 608 Input Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the CEA 608 input stream. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// CEA 608 Input Stream Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="inputStreamId">Id of the CEA 608 input stream. (required)</param>
        public async Task<Models.Cea608CaptionInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List CEA 608 Input Streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Cea608CaptionInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface ICea608ApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/captions/cea608")]
            [AllowAnyStatusCode]
            Task<Models.Cea608CaptionInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Cea608CaptionInputStream cea608CaptionInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/captions/cea608/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/captions/cea608/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.Cea608CaptionInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/captions/cea608")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Cea608CaptionInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
