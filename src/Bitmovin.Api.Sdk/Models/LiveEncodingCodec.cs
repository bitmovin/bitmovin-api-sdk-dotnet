using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// LiveEncodingCodec
    /// </summary>
    public enum LiveEncodingCodec
    {
        /// <summary>
        /// H264
        /// </summary>
        [EnumMember(Value = "H264")]
        H264,

        /// <summary>
        /// H265
        /// </summary>
        [EnumMember(Value = "H265")]
        H265,

        /// <summary>
        /// AAC
        /// </summary>
        [EnumMember(Value = "AAC")]
        AAC
    }
}
