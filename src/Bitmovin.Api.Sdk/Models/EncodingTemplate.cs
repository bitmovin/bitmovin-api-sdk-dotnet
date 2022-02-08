using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// EncodingTemplate
    /// </summary>
    public enum EncodingTemplate
    {
        /// <summary>
        /// H264
        /// </summary>
        [EnumMember(Value = "H264")]
        H264,

        /// <summary>
        /// AV1
        /// </summary>
        [EnumMember(Value = "AV1")]
        AV1
    }
}
