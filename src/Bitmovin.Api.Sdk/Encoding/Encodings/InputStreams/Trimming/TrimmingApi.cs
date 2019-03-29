using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.TimeBased;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.TimecodeTrack;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.H264PictureTiming;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming
{
    public class TrimmingApi
    {
        public TrimmingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            TimeBased = new TimeBasedApi(apiClientFactory);
            TimecodeTrack = new TimecodeTrackApi(apiClientFactory);
            H264PictureTiming = new H264PictureTimingApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of TrimmingApi
        /// </summary>
        public static BitmovinApiBuilder<TrimmingApi> Builder => new BitmovinApiBuilder<TrimmingApi>();

        public TimeBasedApi TimeBased { get; private set; }
        public TimecodeTrackApi TimecodeTrack { get; private set; }
        public H264PictureTimingApi H264PictureTiming { get; private set; }

    }
}
