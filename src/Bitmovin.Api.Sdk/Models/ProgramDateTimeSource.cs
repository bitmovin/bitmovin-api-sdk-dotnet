using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Source for the EXT-X-PROGRAM-DATETIME tag
    /// </summary>
    public enum ProgramDateTimeSource
    {
        /// <summary>
        /// Use the current UTC date time
        /// </summary>
        [EnumMember(Value = "SYSTEM_CLOCK")]
        SYSTEM_CLOCK,

        /// <summary>
        /// Use the timecode in the source video. If no embedded timecode is found in the source, the encoding will fail.
        /// </summary>
        [EnumMember(Value = "EMBEDDED")]
        EMBEDDED
    }
}
