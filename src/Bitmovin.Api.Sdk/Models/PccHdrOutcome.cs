using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PccHdrOutcome
    /// </summary>
    public enum PccHdrOutcome
    {
        /// <summary>
        /// HDR
        /// </summary>
        [EnumMember(Value = "hdr")]
        HDR,

        /// <summary>
        /// SDR
        /// </summary>
        [EnumMember(Value = "sdr")]
        SDR,

        /// <summary>
        /// CLAIMED
        /// </summary>
        [EnumMember(Value = "claimed")]
        CLAIMED,

        /// <summary>
        /// DENIED
        /// </summary>
        [EnumMember(Value = "denied")]
        DENIED,

        /// <summary>
        /// UNESTABLISHED
        /// </summary>
        [EnumMember(Value = "unestablished")]
        UNESTABLISHED,

        /// <summary>
        /// UNREPORTED
        /// </summary>
        [EnumMember(Value = "unreported")]
        UNREPORTED
    }
}
