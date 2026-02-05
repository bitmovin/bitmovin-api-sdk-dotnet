using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H262;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H264;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H265;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Vp8;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Vp9;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Av1;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Mjpeg;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video
{
    /// <summary>
    /// API for VideoApi
    /// </summary>
    public class VideoApi
    {
        /// <summary>
        /// Initializes a new instance of the VideoApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public VideoApi(IBitmovinApiClientFactory apiClientFactory)
        {
            H262 = new H262Api(apiClientFactory);
            H264 = new H264Api(apiClientFactory);
            H265 = new H265Api(apiClientFactory);
            Vp8 = new Vp8Api(apiClientFactory);
            Vp9 = new Vp9Api(apiClientFactory);
            Av1 = new Av1Api(apiClientFactory);
            Mjpeg = new MjpegApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of VideoApi
        /// </summary>
        public static BitmovinApiBuilder<VideoApi> Builder => new BitmovinApiBuilder<VideoApi>();

        /// <summary>
        /// Gets the H262 API
        /// </summary>
        public H262Api H262 { get; }
        /// <summary>
        /// Gets the H264 API
        /// </summary>
        public H264Api H264 { get; }
        /// <summary>
        /// Gets the H265 API
        /// </summary>
        public H265Api H265 { get; }
        /// <summary>
        /// Gets the Vp8 API
        /// </summary>
        public Vp8Api Vp8 { get; }
        /// <summary>
        /// Gets the Vp9 API
        /// </summary>
        public Vp9Api Vp9 { get; }
        /// <summary>
        /// Gets the Av1 API
        /// </summary>
        public Av1Api Av1 { get; }
        /// <summary>
        /// Gets the Mjpeg API
        /// </summary>
        public MjpegApi Mjpeg { get; }
    }
}
