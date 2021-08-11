using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The supported bitrate
    /// </summary>
    public enum MediaConfigBitrate
    {
        /// <summary>
        /// The supported bitrate
        /// </summary>
        [EnumMember(Value = "160000")]
        MCB_160000,

        /// <summary>
        /// The supported bitrate
        /// </summary>
        [EnumMember(Value = "192000")]
        MCB_192000,

        /// <summary>
        /// The supported bitrate
        /// </summary>
        [EnumMember(Value = "224000")]
        MCB_224000,

        /// <summary>
        /// The supported bitrate
        /// </summary>
        [EnumMember(Value = "256000")]
        MCB_256000,

        /// <summary>
        /// The supported bitrate
        /// </summary>
        [EnumMember(Value = "288000")]
        MCB_288000,

        /// <summary>
        /// The supported bitrate
        /// </summary>
        [EnumMember(Value = "320000")]
        MCB_320000,

        /// <summary>
        /// The supported bitrate
        /// </summary>
        [EnumMember(Value = "384000")]
        MCB_384000,

        /// <summary>
        /// The supported bitrate
        /// </summary>
        [EnumMember(Value = "448000")]
        MCB_448000
    }
}
