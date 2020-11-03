using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf
{
    public class CmafApi
    {
        private readonly ICmafApiClient _apiClient;

        public CmafApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICmafApiClient>();
            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CmafApi
        /// </summary>
        public static BitmovinApiBuilder<CmafApi> Builder => new BitmovinApiBuilder<CmafApi>();

        public CustomdataApi Customdata { get; }

        /// <summary>
        /// Add CMAF muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="cmafMuxing">The CMAF muxing to be created</param>
        public async Task<Models.CmafMuxing> CreateAsync(string encodingId, Models.CmafMuxing cmafMuxing)
        {
            return await _apiClient.CreateAsync(encodingId, cmafMuxing);
        }

        /// <summary>
        /// Delete CMAF muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the CMAF muxing (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }

        /// <summary>
        /// CMAF muxing details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="muxingId">Id of the CMAF muxing (required)</param>
        public async Task<Models.CmafMuxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }

        /// <summary>
        /// List CMAF muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CmafMuxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface ICmafApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/muxings/cmaf")]
            [AllowAnyStatusCode]
            Task<Models.CmafMuxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.CmafMuxing cmafMuxing);

            [Delete("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.CmafMuxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);

            [Get("/encoding/encodings/{encoding_id}/muxings/cmaf")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CmafMuxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
