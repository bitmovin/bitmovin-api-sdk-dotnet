using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PaddingDurationUnit
    /// </summary>
    public enum PaddingDurationUnit
    {
        /// <summary>
        /// Duration will be specified in seconds
        /// </summary>
        [EnumMember(Value = "SECONDS")]
        SECONDS,

        /// <summary>
        /// Duration will be specified in number of frames
        /// </summary>
        [EnumMember(Value = "FRAMES")]
        FRAMES
    }
}
