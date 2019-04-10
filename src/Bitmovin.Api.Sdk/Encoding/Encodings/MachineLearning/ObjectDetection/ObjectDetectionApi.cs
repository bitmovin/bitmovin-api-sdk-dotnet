using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning.ObjectDetection.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning.ObjectDetection.Results;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning.ObjectDetection
{
    public class ObjectDetectionApi
    {
        private readonly IObjectDetectionApiClient _apiClient;

        public ObjectDetectionApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IObjectDetectionApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
            Results = new ResultsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ObjectDetectionApi
        /// </summary>
        public static BitmovinApiBuilder<ObjectDetectionApi> Builder => new BitmovinApiBuilder<ObjectDetectionApi>();

        public CustomdataApi Customdata { get; private set; }
        public ResultsApi Results { get; private set; }
        
        /// <summary>
        /// Add object detection configuration to an encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="objectDetectionConfiguration">The request payload</param>
        public async Task<Models.ObjectDetectionConfiguration> CreateAsync(string encodingId, Models.ObjectDetectionConfiguration objectDetectionConfiguration)
        {
            return await _apiClient.CreateAsync(encodingId, objectDetectionConfiguration);
        }
        
        /// <summary>
        /// Delete object detection configuration
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="objectDetectionId">Id of the object detection configuration to be deleted</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string objectDetectionId)
        {
            return await _apiClient.DeleteAsync(encodingId, objectDetectionId);
        }
        
        /// <summary>
        /// Get object detection configuration details
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="objectDetectionId">Id of the object detection configuration</param>
        public async Task<Models.ObjectDetectionConfiguration> GetAsync(string encodingId, string objectDetectionId)
        {
            return await _apiClient.GetAsync(encodingId, objectDetectionId);
        }
        
        /// <summary>
        /// List object detection configurations of an encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ObjectDetectionConfiguration>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IObjectDetectionApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/machine-learning/object-detection")]
            [AllowAnyStatusCode]
            Task<Models.ObjectDetectionConfiguration> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ObjectDetectionConfiguration objectDetectionConfiguration);
            
            [Delete("/encoding/encodings/{encoding_id}/machine-learning/object-detection/{object_detection_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("object_detection_id")] string objectDetectionId);
            
            [Get("/encoding/encodings/{encoding_id}/machine-learning/object-detection/{object_detection_id}")]
            [AllowAnyStatusCode]
            Task<Models.ObjectDetectionConfiguration> GetAsync([Path("encoding_id")] string encodingId, [Path("object_detection_id")] string objectDetectionId);
            
            [Get("/encoding/encodings/{encoding_id}/machine-learning/object-detection")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ObjectDetectionConfiguration>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
