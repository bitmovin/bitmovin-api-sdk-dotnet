using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts
{
    public class TsApi
    {
        private readonly ITsApiClient _apiClient;

        public TsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITsApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
            Drm = new DrmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of TsApi
        /// </summary>
        public static BitmovinApiBuilder<TsApi> Builder => new BitmovinApiBuilder<TsApi>();

        public CustomdataApi Customdata { get; }
        public DrmApi Drm { get; }

        /// <summary>
        /// Add TS muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="tsMuxing">The TS muxing to be created</param>
        public async Task<Models.TsMuxing> CreateAsync(string encodingId, Models.TsMuxing tsMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, tsMuxing);
        }

        /// <summary>
        /// Delete TS muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the TS muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// TS muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the TS muxing (required)</param>
        public async Task<Models.TsMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List TS muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TsMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface ITsApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/ts")]
            [AllowAnyStatusCode]
            Task<Models.TsMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.TsMuxing tsMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.TsMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/ts")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TsMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
