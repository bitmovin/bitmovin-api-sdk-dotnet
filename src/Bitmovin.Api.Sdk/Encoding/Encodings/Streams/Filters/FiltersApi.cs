using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Filters
{
    public class FiltersApi
    {
        private readonly IFiltersApiClient _apiClient;

        public FiltersApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFiltersApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of FiltersApi
        /// </summary>
        public static BitmovinApiBuilder<FiltersApi> Builder => new BitmovinApiBuilder<FiltersApi>();

        
        /// <summary>
        /// Add Filters to Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="streamFilter">The request payload</param>
        public async Task<Models.StreamFilterList> CreateAsync(string encodingId, string streamId, List<Models.StreamFilter> streamFilter)
        {
            return await _apiClient.CreateAsync(encodingId, streamId, streamFilter);
        }
        
        /// <summary>
        /// Delete Specific Filter from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="filterId">Id of the filter</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string streamId, string filterId)
        {
            return await _apiClient.DeleteAsync(encodingId, streamId, filterId);
        }
        
        /// <summary>
        /// Delete All Filters from Stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        public async Task<Models.BitmovinResponseList> DeleteAllAsync(string encodingId, string streamId)
        {
            return await _apiClient.DeleteAllAsync(encodingId, streamId);
        }
        
        /// <summary>
        /// List the filters of a stream
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="streamId">Id of the stream.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.StreamFilterList> ListAsync(string encodingId, string streamId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, streamId, q);
        }
        
        internal interface IFiltersApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/streams/{stream_id}/filters")]
            [AllowAnyStatusCode]
            Task<Models.StreamFilterList> CreateAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Body] List<Models.StreamFilter> streamFilter);
            
            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/filters/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [Path("filter_id")] string filterId);
            
            [Delete("/encoding/encodings/{encoding_id}/streams/{stream_id}/filters")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponseList> DeleteAllAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId);
            
            [Get("/encoding/encodings/{encoding_id}/streams/{stream_id}/filters")]
            [AllowAnyStatusCode]
            Task<Models.StreamFilterList> ListAsync([Path("encoding_id")] string encodingId, [Path("stream_id")] string streamId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
