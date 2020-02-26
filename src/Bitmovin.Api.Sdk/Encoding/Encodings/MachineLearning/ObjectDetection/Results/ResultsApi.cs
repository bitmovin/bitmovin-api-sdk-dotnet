using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning.ObjectDetection.Results.ByTimestamp;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning.ObjectDetection.Results
{
    public class ResultsApi
    {
        private readonly IResultsApiClient _apiClient;

        public ResultsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IResultsApiClient>();
            ByTimestamp = new ByTimestampApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ResultsApi
        /// </summary>
        public static BitmovinApiBuilder<ResultsApi> Builder => new BitmovinApiBuilder<ResultsApi>();

        public ByTimestampApi ByTimestamp { get; }

        /// <summary>
        /// List object detection results
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="objectDetectionId">Id of the object detection configuration (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ObjectDetectionResult>> ListAsync(string encodingId, string objectDetectionId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, objectDetectionId, q);
        }

        internal interface IResultsApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/machine-learning/object-detection/{object_detection_id}/results")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ObjectDetectionResult>> ListAsync([Path("encoding_id")] string encodingId, [Path("object_detection_id")] string objectDetectionId, [QueryMap] IDictionary<String, Object> queryParams);
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
