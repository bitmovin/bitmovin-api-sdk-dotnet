using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Captions.Cea.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Captions.Cea
{
    public class CeaApi
    {
        private readonly ICeaApiClient _apiClient;

        public CeaApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICeaApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of CeaApi
        /// </summary>
        public static BitmovinApiBuilder<CeaApi> Builder => new BitmovinApiBuilder<CeaApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// TS Embed CEA 608/708 Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the TS muxing.</param>
        /// <param name="captionsEmbedCea">The request payload</param>
        public async Task<Models.CaptionsEmbedCea> CreateAsync(string encodingId, string muxingId, Models.CaptionsEmbedCea captionsEmbedCea)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, captionsEmbedCea);
        }
        
        /// <summary>
        /// Delete Embedded CEA 608/708 Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the TS muxing.</param>
        /// <param name="captionsId">Id of the subtitle.</param>
        public async Task<Models.CaptionsEmbedCea> DeleteAsync(string encodingId, string muxingId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, captionsId);
        }
        
        /// <summary>
        /// Embedded CEA 608/708 Captions Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the TS muxing.</param>
        /// <param name="captionsId">Id of the captions.</param>
        public async Task<Models.CaptionsEmbedCea> GetAsync(string encodingId, string muxingId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, captionsId);
        }
        
        /// <summary>
        /// List TS Embedded CEA 608/708 Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the TS muxing.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CaptionsEmbedCea>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }
        
        internal interface ICeaApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/captions/cea")]
            [AllowAnyStatusCode]
            Task<Models.CaptionsEmbedCea> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.CaptionsEmbedCea captionsEmbedCea);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/captions/cea/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.CaptionsEmbedCea> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/captions/cea/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.CaptionsEmbedCea> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/captions/cea")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CaptionsEmbedCea>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

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
