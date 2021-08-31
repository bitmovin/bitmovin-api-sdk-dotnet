using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PresetConfiguration
    /// </summary>
    public enum PresetConfiguration
    {
        /// <summary>
        /// supported for H264
        /// </summary>
        [EnumMember(Value = "LIVE_ULTRAHIGH_QUALITY")]
        LIVE_ULTRAHIGH_QUALITY,

        /// <summary>
        /// supported for H264
        /// </summary>
        [EnumMember(Value = "LIVE_VERYHIGH_QUALITY")]
        LIVE_VERYHIGH_QUALITY,

        /// <summary>
        /// supported for H264, H265
        /// </summary>
        [EnumMember(Value = "LIVE_HIGH_QUALITY")]
        LIVE_HIGH_QUALITY,

        /// <summary>
        /// supported for H264
        /// </summary>
        [EnumMember(Value = "LIVE_STANDARD")]
        LIVE_STANDARD,

        /// <summary>
        /// supported for H264, H265
        /// </summary>
        [EnumMember(Value = "LIVE_LOW_LATENCY")]
        LIVE_LOW_LATENCY,

        /// <summary>
        /// supported for H264
        /// </summary>
        [EnumMember(Value = "LIVE_LOWER_LATENCY")]
        LIVE_LOWER_LATENCY,

        /// <summary>
        /// supported for H264
        /// </summary>
        [EnumMember(Value = "LIVE_VERYLOW_LATENCY")]
        LIVE_VERYLOW_LATENCY,

        /// <summary>
        /// supported for H264, H265, VP9
        /// </summary>
        [EnumMember(Value = "VOD_HIGH_QUALITY")]
        VOD_HIGH_QUALITY,

        /// <summary>
        /// supported for H264
        /// </summary>
        [EnumMember(Value = "VOD_QUALITY")]
        VOD_QUALITY,

        /// <summary>
        /// supported for H264, H265, VP9
        /// </summary>
        [EnumMember(Value = "VOD_STANDARD")]
        VOD_STANDARD,

        /// <summary>
        /// supported for H264, H265, VP9
        /// </summary>
        [EnumMember(Value = "VOD_SPEED")]
        VOD_SPEED,

        /// <summary>
        /// supported for H264, H265
        /// </summary>
        [EnumMember(Value = "VOD_HIGH_SPEED")]
        VOD_HIGH_SPEED,

        /// <summary>
        /// supported for H264, H265
        /// </summary>
        [EnumMember(Value = "VOD_VERYHIGH_SPEED")]
        VOD_VERYHIGH_SPEED,

        /// <summary>
        /// supported for H264, H265
        /// </summary>
        [EnumMember(Value = "VOD_EXTRAHIGH_SPEED")]
        VOD_EXTRAHIGH_SPEED,

        /// <summary>
        /// supported for H264, H265
        /// </summary>
        [EnumMember(Value = "VOD_SUPERHIGH_SPEED")]
        VOD_SUPERHIGH_SPEED,

        /// <summary>
        /// supported for H264, H265
        /// </summary>
        [EnumMember(Value = "VOD_ULTRAHIGH_SPEED")]
        VOD_ULTRAHIGH_SPEED
    }
}
