using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PresetConfiguration
    /// </summary>
    public enum PresetConfiguration
    {
        /// <summary>
        /// LIVE_ULTRAHIGH_QUALITY
        /// </summary>
        [EnumMember(Value = "LIVE_ULTRAHIGH_QUALITY")]
        LIVE_ULTRAHIGH_QUALITY,

        /// <summary>
        /// LIVE_VERYHIGH_QUALITY
        /// </summary>
        [EnumMember(Value = "LIVE_VERYHIGH_QUALITY")]
        LIVE_VERYHIGH_QUALITY,

        /// <summary>
        /// LIVE_HIGH_QUALITY
        /// </summary>
        [EnumMember(Value = "LIVE_HIGH_QUALITY")]
        LIVE_HIGH_QUALITY,

        /// <summary>
        /// LIVE_STANDARD
        /// </summary>
        [EnumMember(Value = "LIVE_STANDARD")]
        LIVE_STANDARD,

        /// <summary>
        /// LIVE_LOW_LATENCY
        /// </summary>
        [EnumMember(Value = "LIVE_LOW_LATENCY")]
        LIVE_LOW_LATENCY,

        /// <summary>
        /// LIVE_LOWER_LATENCY
        /// </summary>
        [EnumMember(Value = "LIVE_LOWER_LATENCY")]
        LIVE_LOWER_LATENCY,

        /// <summary>
        /// LIVE_VERYLOW_LATENCY
        /// </summary>
        [EnumMember(Value = "LIVE_VERYLOW_LATENCY")]
        LIVE_VERYLOW_LATENCY,

        /// <summary>
        /// VOD_HIGH_QUALITY
        /// </summary>
        [EnumMember(Value = "VOD_HIGH_QUALITY")]
        VOD_HIGH_QUALITY,

        /// <summary>
        /// VOD_HIGH_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_HIGH_SPEED")]
        VOD_HIGH_SPEED,

        /// <summary>
        /// VOD_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_SPEED")]
        VOD_SPEED,

        /// <summary>
        /// VOD_STANDARD
        /// </summary>
        [EnumMember(Value = "VOD_STANDARD")]
        VOD_STANDARD,

        /// <summary>
        /// VOD_EXTRAHIGH_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_EXTRAHIGH_SPEED")]
        VOD_EXTRAHIGH_SPEED,

        /// <summary>
        /// VOD_VERYHIGH_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_VERYHIGH_SPEED")]
        VOD_VERYHIGH_SPEED,

        /// <summary>
        /// VOD_SUPERHIGH_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_SUPERHIGH_SPEED")]
        VOD_SUPERHIGH_SPEED,

        /// <summary>
        /// VOD_ULTRAHIGH_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_ULTRAHIGH_SPEED")]
        VOD_ULTRAHIGH_SPEED
    }
}
