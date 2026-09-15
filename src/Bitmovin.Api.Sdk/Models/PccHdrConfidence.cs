using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Which instrument established the picture, where anything did.
    /// </summary>
    public enum PccHdrConfidence
    {
        /// <summary>
        /// Which instrument established the picture, where anything did.
        /// </summary>
        [EnumMember(Value = "evidence")]
        EVIDENCE,

        /// <summary>
        /// Which instrument established the picture, where anything did.
        /// </summary>
        [EnumMember(Value = "claim")]
        CLAIM,

        /// <summary>
        /// Which instrument established the picture, where anything did.
        /// </summary>
        [EnumMember(Value = "unestablished")]
        UNESTABLISHED
    }
}
