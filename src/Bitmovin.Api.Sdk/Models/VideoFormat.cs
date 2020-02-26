using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// VideoFormat
    /// </summary>
    public enum VideoFormat
    {
        /// <summary>
        /// UNDEFINED
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED,

        /// <summary>
        /// COMPONENT
        /// </summary>
        [EnumMember(Value = "COMPONENT")]
        COMPONENT,

        /// <summary>
        /// PAL
        /// </summary>
        [EnumMember(Value = "PAL")]
        PAL,

        /// <summary>
        /// NTSC
        /// </summary>
        [EnumMember(Value = "NTSC")]
        NTSC,

        /// <summary>
        /// SECAM
        /// </summary>
        [EnumMember(Value = "SECAM")]
        SECAM,

        /// <summary>
        /// MAC
        /// </summary>
        [EnumMember(Value = "MAC")]
        MAC
    }
}
