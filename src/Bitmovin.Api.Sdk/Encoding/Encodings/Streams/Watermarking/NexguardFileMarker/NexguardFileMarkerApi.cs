using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Watermarking.NexguardFileMarker.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Watermarking.NexguardFileMarker
{
    public class NexguardFileMarkerApi
    {
        private readonly INexguardFileMarkerApiClient _apiClient;

        public NexguardFileMarkerApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<INexguardFileMarkerApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of NexguardFileMarkerApi
        /// </summary>
        public static BitmovinApiBuilder<NexguardFileMarkerApi> Builder => new BitmovinApiBuilder<NexguardFileMarkerApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add a nexguard file marker watermarking configurations
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="nexGuardFileMarker">The nexguard file marker configurations</param>
        public async Task<Models.NexGuardFileMarker> CreateAsync(string encodingId, string streamId, Models.NexGuardFileMarker nexGuardFileMarker)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, nexGuardFileMarker);
        }

        /// <summary>
        /// Delete nexguard file marker watermarking configurations
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="nexguardId">Id of the nexguard file marker watermarking configurations (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string nexguardId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, nexguardId);
        }

        /// <summary>
        /// Nexguard file marker watermarking configurations details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="nexguardId">Id of the nexguard file marker watermarking configurations. (required)</param>
        public async Task<Models.NexGuardFileMarker> GetAsync(string encodingId, string streamId, string nexguardId)
        {
            return await _apiClient.GetAsync(encodingId, streamId, nexguardId);
        }

        /// <summary>
        /// List nexguard file marker watermarking configurations
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.NexGuardFileMarker>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface INexguardFileMarkerApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/watermarking/nexguard-file-marker")]
            [AllowAnyStatusCode]
            Task<Models.NexGuardFileMarker> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] Models.NexGuardFileMarker nexGuardFileMarker);

            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/watermarking/nexguard-file-marker/{nexguard_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("nexguard_id")] string nexguardId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/watermarking/nexguard-file-marker/{nexguard_id}")]
            [AllowAnyStatusCode]
            Task<Models.NexGuardFileMarker> GetAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("nexguard_id")] string nexguardId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/watermarking/nexguard-file-marker")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.NexGuardFileMarker>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
