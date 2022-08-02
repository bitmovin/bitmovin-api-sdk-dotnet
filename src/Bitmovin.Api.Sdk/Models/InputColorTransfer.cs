using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// InputColorTransfer
    /// </summary>
    public enum InputColorTransfer
    {
        /// <summary>
        /// UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        /// <summary>
        /// BT709
        /// </summary>
        [EnumMember(Value = "BT709")]
        BT709,

        /// <summary>
        /// GAMMA22
        /// </summary>
        [EnumMember(Value = "GAMMA22")]
        GAMMA22,

        /// <summary>
        /// GAMMA28
        /// </summary>
        [EnumMember(Value = "GAMMA28")]
        GAMMA28,

        /// <summary>
        /// SMPTE170M
        /// </summary>
        [EnumMember(Value = "SMPTE170M")]
        SMPTE170M,

        /// <summary>
        /// SMPTE240M
        /// </summary>
        [EnumMember(Value = "SMPTE240M")]
        SMPTE240M,

        /// <summary>
        /// LINEAR
        /// </summary>
        [EnumMember(Value = "LINEAR")]
        LINEAR,

        /// <summary>
        /// LOG
        /// </summary>
        [EnumMember(Value = "LOG")]
        LOG,

        /// <summary>
        /// LOG_SQRT
        /// </summary>
        [EnumMember(Value = "LOG_SQRT")]
        LOG_SQRT,

        /// <summary>
        /// IEC61966_2_4
        /// </summary>
        [EnumMember(Value = "IEC61966_2_4")]
        IEC61966_2_4,

        /// <summary>
        /// BT1361_ECG
        /// </summary>
        [EnumMember(Value = "BT1361_ECG")]
        BT1361_ECG,

        /// <summary>
        /// IEC61966_2_1
        /// </summary>
        [EnumMember(Value = "IEC61966_2_1")]
        IEC61966_2_1,

        /// <summary>
        /// BT2020_10
        /// </summary>
        [EnumMember(Value = "BT2020_10")]
        BT2020_10,

        /// <summary>
        /// BT2020_12
        /// </summary>
        [EnumMember(Value = "BT2020_12")]
        BT2020_12,

        /// <summary>
        /// SMPTE2084
        /// </summary>
        [EnumMember(Value = "SMPTE2084")]
        SMPTE2084,

        /// <summary>
        /// SMPTE428
        /// </summary>
        [EnumMember(Value = "SMPTE428")]
        SMPTE428,

        /// <summary>
        /// ARIB_STD_B67
        /// </summary>
        [EnumMember(Value = "ARIB_STD_B67")]
        ARIB_STD_B67
    }
}
