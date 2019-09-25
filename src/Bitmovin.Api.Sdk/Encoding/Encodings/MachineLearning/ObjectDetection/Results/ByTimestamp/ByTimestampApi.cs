using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning.ObjectDetection.Results.ByTimestamp
{
    public class ByTimestampApi
    {
        private readonly IByTimestampApiClient _apiClient;

        public ByTimestampApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IByTimestampApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of ByTimestampApi
        /// </summary>
        public static BitmovinApiBuilder<ByTimestampApi> Builder => new BitmovinApiBuilder<ByTimestampApi>();

        
        /// <summary>
        /// List object detection results grouped by timestamp
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="objectDetectionId">Id of the object detection configuration</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ObjectDetectionTimestampResult>> ListAsync(string encodingId, string objectDetectionId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, objectDetectionId, q);
        }
        
        internal interface IByTimestampApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/machine-learning/object-detection/{object_detection_id}/results/by-timestamp")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ObjectDetectionTimestampResult>> ListAsync([Path("encoding_id")] string encodingId, [Path("object_detection_id")] string objectDetectionId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
