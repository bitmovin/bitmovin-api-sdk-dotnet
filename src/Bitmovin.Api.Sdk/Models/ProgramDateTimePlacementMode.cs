using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Placement mode of the ProgramDateTime tag.
    /// </summary>
    public enum ProgramDateTimePlacementMode
    {
        /// <summary>
        /// Only place the ProgramDateTime tag once at the first segment of a playlist
        /// </summary>
        [EnumMember(Value = "ONCE_PER_PLAYLIST")]
        ONCE_PER_PLAYLIST,

        /// <summary>
        /// Place the ProgramDateTime tag every X segments
        /// </summary>
        [EnumMember(Value = "SEGMENTS_INTERVAL")]
        SEGMENTS_INTERVAL,

        /// <summary>
        /// Place the ProgramDateTime tag every X seconds
        /// </summary>
        [EnumMember(Value = "SECONDS_INTERVAL")]
        SECONDS_INTERVAL
    }
}
