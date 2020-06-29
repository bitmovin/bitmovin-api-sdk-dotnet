using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Audio volume format
    /// </summary>
    public enum AudioVolumeFormat
    {
        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "U8")]
        U8,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "S16")]
        S16,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "S32")]
        S32,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "U8P")]
        U8P,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "S16P")]
        S16P,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "S32P")]
        S32P,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "S64")]
        S64,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "S64P")]
        S64P,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "FLT")]
        FLT,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "FLTP")]
        FLTP,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "DBL")]
        DBL,

        /// <summary>
        /// Audio volume format
        /// </summary>
        [EnumMember(Value = "DBLP")]
        DBLP
    }
}
