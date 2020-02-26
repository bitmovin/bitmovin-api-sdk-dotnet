using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// HlsVersion
    /// </summary>
    public enum HlsVersion
    {
        /// <summary>
        /// HLS version 3
        /// </summary>
        [EnumMember(Value = "3")]
        HLS_V3,

        /// <summary>
        /// HLS version 4
        /// </summary>
        [EnumMember(Value = "4")]
        HLS_V4,

        /// <summary>
        /// HLS version 5
        /// </summary>
        [EnumMember(Value = "5")]
        HLS_V5,

        /// <summary>
        /// HLS version 6
        /// </summary>
        [EnumMember(Value = "6")]
        HLS_V6,

        /// <summary>
        /// HLS version 7
        /// </summary>
        [EnumMember(Value = "7")]
        HLS_V7,

        /// <summary>
        /// HLS version 8
        /// </summary>
        [EnumMember(Value = "8")]
        HLS_V8
    }
}
