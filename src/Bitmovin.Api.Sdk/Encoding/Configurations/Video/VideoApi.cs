using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H264;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.H265;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Vp8;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Vp9;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Av1;
using Bitmovin.Api.Sdk.Encoding.Configurations.Video.Mjpeg;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Video
{
    public class VideoApi
    {
        public VideoApi(IBitmovinApiClientFactory apiClientFactory)
        {
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

        public H264Api H264 { get; private set; }
        public H265Api H265 { get; private set; }
        public Vp8Api Vp8 { get; private set; }
        public Vp9Api Vp9 { get; private set; }
        public Av1Api Av1 { get; private set; }
        public MjpegApi Mjpeg { get; private set; }

    }
}
