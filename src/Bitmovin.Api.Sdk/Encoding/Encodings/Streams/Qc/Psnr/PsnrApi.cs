using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Qc.Psnr
{
    public class PsnrApi
    {
        private readonly IPsnrApiClient _apiClient;

        public PsnrApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IPsnrApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of PsnrApi
        /// </summary>
        public static BitmovinApiBuilder<PsnrApi> Builder => new BitmovinApiBuilder<PsnrApi>();

        /// <summary>
        /// PSNR quality metrics
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        public async Task<Models.BitmovinResponse> CreateAsync(string encodingId, string streamId)
        {
            return await _apiClient.CreateAsync(encodingId, streamId);
        }

        /// <summary>
        /// Get Stream PSNR metrics
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="streamId">Id of the stream. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.PsnrQualityMetric>> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }

        internal interface IPsnrApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/qc/psnr")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId);

            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/qc/psnr")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.PsnrQualityMetric>> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
