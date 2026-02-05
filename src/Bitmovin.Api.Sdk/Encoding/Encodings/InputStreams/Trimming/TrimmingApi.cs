using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.TimeBased;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.TimecodeTrack;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming.H264PictureTiming;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams.Trimming
{
    /// <summary>
    /// API for TrimmingApi
    /// </summary>
    public class TrimmingApi
    {
        /// <summary>
        /// Initializes a new instance of the TrimmingApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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

        /// <summary>
        /// Gets the TimeBased API
        /// </summary>
        public TimeBasedApi TimeBased { get; }
        /// <summary>
        /// Gets the TimecodeTrack API
        /// </summary>
        public TimecodeTrackApi TimecodeTrack { get; }
        /// <summary>
        /// Gets the H264PictureTiming API
        /// </summary>
        public H264PictureTimingApi H264PictureTiming { get; }
    }
}
