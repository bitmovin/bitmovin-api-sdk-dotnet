using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning.ObjectDetection.Customdata
{
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        
        /// <summary>
        /// Get the custom data of an object detection configuration
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="objectDetectionId">Id of the object detection configuration</param>
        public async Task<Models.CustomData> GetAsync(string encodingId, string objectDetectionId)
        {
            return await _apiClient.GetAsync(encodingId, objectDetectionId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/machine-learning/object-detection/{object_detection_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("encoding_id")] string encodingId, [Path("object_detection_id")] string objectDetectionId);
            
        }
        
    }
}
