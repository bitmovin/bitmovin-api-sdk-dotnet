using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Scte35Triggers
{
    public class Scte35TriggersApi
    {
        private readonly IScte35TriggersApiClient _apiClient;

        public Scte35TriggersApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IScte35TriggersApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of Scte35TriggersApi
        /// </summary>
        public static BitmovinApiBuilder<Scte35TriggersApi> Builder => new BitmovinApiBuilder<Scte35TriggersApi>();

        /// <summary>
        /// Create SCTE 35 trigger
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="scte35Trigger">The SCTE 35 trigger to be created</param>
        public async Task<Models.Scte35Trigger> CreateAsync(string encodingId, Models.Scte35Trigger scte35Trigger)
        {
            return await _apiClient.CreateAsync(encodingId, scte35Trigger);
        }

        /// <summary>
        /// Delete SCTE 35 trigger
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="scte35triggerId">Id of the SCTE 35 trigger (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string scte35triggerId)
        {
            return await _apiClient.DeleteAsync(encodingId, scte35triggerId);
        }

        /// <summary>
        /// SCTE 35 trigger Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="scte35triggerId">Id of the SCTE 35 trigger (required)</param>
        public async Task<Models.Scte35Trigger> GetAsync(string encodingId, string scte35triggerId)
        {
            return await _apiClient.GetAsync(encodingId, scte35triggerId);
        }

        /// <summary>
        /// List all SCTE 35 triggers for an encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Scte35Trigger>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }

        internal interface IScte35TriggersApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/scte-35-triggers")]
            [AllowAnyStatusCode]
            Task<Models.Scte35Trigger> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Scte35Trigger scte35Trigger);

            [Delete("/encoding/encodings/{encoding_id}/scte-35-triggers/{scte35trigger_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("scte35trigger_id")] string scte35triggerId);

            [Get("/encoding/encodings/{encoding_id}/scte-35-triggers/{scte35trigger_id}")]
            [AllowAnyStatusCode]
            Task<Models.Scte35Trigger> GetAsync([Path("encoding_id")] string encodingId, [Path("scte35trigger_id")] string scte35triggerId);

            [Get("/encoding/encodings/{encoding_id}/scte-35-triggers")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Scte35Trigger>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
