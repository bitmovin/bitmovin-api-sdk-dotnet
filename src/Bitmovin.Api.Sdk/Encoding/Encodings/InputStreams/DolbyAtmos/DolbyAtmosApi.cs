using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.DolbyAtmos
{
    /// <summary>
    /// API for DolbyAtmosApi
    /// </summary>
    public class DolbyAtmosApi
    {
        private readonly IDolbyAtmosApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the DolbyAtmosApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public DolbyAtmosApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDolbyAtmosApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of DolbyAtmosApi
        /// </summary>
        public static BitmovinApiBuilder<DolbyAtmosApi> Builder => new BitmovinApiBuilder<DolbyAtmosApi>();

        /// <summary>
        /// Add Dolby Atmos input stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="dolbyAtmosIngestInputStream">The Dolby Atmos input stream to be created</param>
        public async Task<Models.DolbyAtmosIngestInputStream> CreateAsync(string encodingId, Models.DolbyAtmosIngestInputStream dolbyAtmosIngestInputStream)
        {
            return await _apiClient.CreateAsync(encodingId, dolbyAtmosIngestInputStream);
        }

        /// <summary>
        /// Delete Dolby Atmos input stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="inputStreamId">Id of the Dolby Atmos input stream (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.DeleteAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// Dolby Atmos input stream details
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="inputStreamId">Id of the Dolby Atmos input stream (required)</param>
        public async Task<Models.DolbyAtmosIngestInputStream> GetAsync(string encodingId, string inputStreamId)
        {
            return await _apiClient.GetAsync(encodingId, inputStreamId);
        }

        /// <summary>
        /// List Dolby Atmos input streams
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DolbyAtmosIngestInputStream>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IDolbyAtmosApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/input-streams/dolby-atmos")]
            [AllowAnyStatusCode]
            Task<Models.DolbyAtmosIngestInputStream> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.DolbyAtmosIngestInputStream dolbyAtmosIngestInputStream);

            [Delete("/encoding/encodings/{encoding_id}/input-streams/dolby-atmos/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/dolby-atmos/{input_stream_id}")]
            [AllowAnyStatusCode]
            Task<Models.DolbyAtmosIngestInputStream> GetAsync([Path("encoding_id")] string encodingId, [Path("input_stream_id")] string inputStreamId);

            [Get("/encoding/encodings/{encoding_id}/input-streams/dolby-atmos")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DolbyAtmosIngestInputStream>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
