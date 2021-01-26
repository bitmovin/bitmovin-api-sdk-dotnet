using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.PackedAudio.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.PackedAudio.Information;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.PackedAudio
{
    public class PackedAudioApi
    {
        private readonly IPackedAudioApiClient _apiClient;

        public PackedAudioApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPackedAudioApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Information = new InformationApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of PackedAudioApi
        /// </summary>
        public static BitmovinApiBuilder<PackedAudioApi> Builder => new BitmovinApiBuilder<PackedAudioApi>();

        public CustomdataApi Customdata { get; }
        public InformationApi Information { get; }

        /// <summary>
        /// Add Packed Audio muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="packedAudioMuxing">The Packed Audio muxing to be created</param>
        public async Task<Models.PackedAudioMuxing> CreateAsync(string encodingId, Models.PackedAudioMuxing packedAudioMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, packedAudioMuxing);
        }

        /// <summary>
        /// Delete Packed Audio muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Packed Audio muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// Packed Audio muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the Packed Audio muxing (required)</param>
        public async Task<Models.PackedAudioMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List Packed Audio muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PackedAudioMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IPackedAudioApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/packed-audio")]
            [AllowAnyStatusCode]
            Task<Models.PackedAudioMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.PackedAudioMuxing packedAudioMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/packed-audio/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/packed-audio/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.PackedAudioMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/packed-audio")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PackedAudioMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
