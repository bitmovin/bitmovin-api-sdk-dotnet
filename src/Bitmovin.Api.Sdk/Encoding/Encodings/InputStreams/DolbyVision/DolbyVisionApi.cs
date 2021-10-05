using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.DolbyVision
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
        /// Add Dolby Vision input stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="dolbyVisionInputStream">The Dolby Vision input stream to be created</param>
        public async Task<Models.DolbyVisionInputStream> CreateAsync(string encodingId, Models.DolbyVisionInputStream dolbyVisionInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, dolbyVisionInputStream);
        }

        /// <summary>
        /// Delete Dolby Vision input stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="dolbyVisionInputStreamId">Id of the Dolby Vision input stream. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string dolbyVisionInputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, dolbyVisionInputStreamId);
        }

        /// <summary>
        /// Dolby Vision input stream details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="dolbyVisionInputStreamId">Id of the Dolby Vision input stream. (required)</param>
        public async Task<Models.DolbyVisionInputStream> GetAsync(string encodingId, string dolbyVisionInputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, dolbyVisionInputStreamId);
        }

        /// <summary>
        /// List Dolby Vision input stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DolbyVisionInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IDolbyVisionApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/dolby-vision")]
            [AllowAnyStatusCode]
            Task<Models.DolbyVisionInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.DolbyVisionInputStream dolbyVisionInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/dolby-vision/{dolby_vision_input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("dolby_vision_input_stream_id")] string dolbyVisionInputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/dolby-vision/{dolby_vision_input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.DolbyVisionInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("dolby_vision_input_stream_id")] string dolbyVisionInputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/dolby-vision")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DolbyVisionInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
