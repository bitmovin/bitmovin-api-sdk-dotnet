using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Id3.Raw;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Id3.FrameId;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Id3.PlainText;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Id3
{
    public class Id3Api
    {
        private readonly IId3ApiClient _apiClient;

        public Id3Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IId3ApiClient>();

            Raw = new RawApi(apiClientFactory);
            FrameId = new FrameIdApi(apiClientFactory);
            PlainText = new PlainTextApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Id3Api
        /// </summary>
        public static BitmovinApiBuilder<Id3Api> Builder => new BitmovinApiBuilder<Id3Api>();

        public RawApi Raw { get; private set; }
        public FrameIdApi FrameId { get; private set; }
        public PlainTextApi PlainText { get; private set; }
        
        /// <summary>
        /// List all ID3 Tags of Progressive TS Muxing
        /// </summary>
        /// <param name="encodingId">ID of the Encoding.</param>
        /// <param name="muxingId">ID of the Progressive TS Muxing</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Id3Tag>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }
        
        internal interface IId3ApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/id3")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Id3Tag>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
