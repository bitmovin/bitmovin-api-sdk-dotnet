using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning.ObjectDetection;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning
{
    public class MachineLearningApi
    {
        public MachineLearningApi(IBitmovinApiClientFactory apiClientFactory)
        {
            ObjectDetection = new ObjectDetectionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MachineLearningApi
        /// </summary>
        public static BitmovinApiBuilder<MachineLearningApi> Builder => new BitmovinApiBuilder<MachineLearningApi>();

        public ObjectDetectionApi ObjectDetection { get; }
    }
}
