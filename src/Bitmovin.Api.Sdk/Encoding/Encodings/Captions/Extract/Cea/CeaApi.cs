using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Cea.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Captions.Extract.Cea
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
        /// Extract CEA 608/708 Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsCea">The request payload</param>
        public async Task<Models.CaptionsCea> CreateAsync(string encodingId, Models.CaptionsCea captionsCea)
        {
            return await _apiClient.CreateAsync(encodingId, captionsCea);
        }
        
        /// <summary>
        /// Delete CEA 608/708 Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsId">Id of the captions configuration.</param>
        public async Task<Models.CaptionsCea> DeleteAsync(string encodingId, string captionsId)
        {
            return await _apiClient.DeleteAsync(encodingId, captionsId);
        }
        
        /// <summary>
        /// CEA 608/708 Captions Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="captionsId">Id of the captions.</param>
        public async Task<Models.CaptionsCea> GetAsync(string encodingId, string captionsId)
        {
            return await _apiClient.GetAsync(encodingId, captionsId);
        }
        
        /// <summary>
        /// List CEA 608/708 Captions
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.CaptionsCea>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface ICeaApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/captions/extract/cea")]
            [AllowAnyStatusCode]
            Task<Models.CaptionsCea> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.CaptionsCea captionsCea);
            
            [Delete("/encoding/encodings/{encoding_id}/captions/extract/cea/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.CaptionsCea> DeleteAsync([Path("encoding_id")] string encodingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/extract/cea/{captions_id}")]
            [AllowAnyStatusCode]
            Task<Models.CaptionsCea> GetAsync([Path("encoding_id")] string encodingId, [Path("captions_id")] string captionsId);
            
            [Get("/encoding/encodings/{encoding_id}/captions/extract/cea")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.CaptionsCea>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
