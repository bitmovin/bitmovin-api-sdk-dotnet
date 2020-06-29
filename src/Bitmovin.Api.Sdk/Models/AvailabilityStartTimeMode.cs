using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AvailabilityStartTimeMode
    /// </summary>
    public enum AvailabilityStartTimeMode
    {
        /// <summary>
        /// The availabilityStartTime will be set to the time, the first segment is available
        /// </summary>
        [EnumMember(Value = "ON_FIRST_SEGMENT")]
        ON_FIRST_SEGMENT,

        /// <summary>
        /// The availabilityStartTime will be set to the time, the encoder starts encoding and the stream is ingesting
        /// </summary>
        [EnumMember(Value = "ON_STREAM_INGEST")]
        ON_STREAM_INGEST
    }
}
