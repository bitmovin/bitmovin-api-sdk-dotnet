using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Id3TagType
    /// </summary>
    public enum Id3TagType
    {
        /// <summary>
        /// RAW
        /// </summary>
        [EnumMember(Value = "RAW")]
        RAW,

        /// <summary>
        /// FRAME_ID
        /// </summary>
        [EnumMember(Value = "FRAME_ID")]
        FRAME_ID,

        /// <summary>
        /// PLAIN_TEXT
        /// </summary>
        [EnumMember(Value = "PLAIN_TEXT")]
        PLAIN_TEXT
    }
}
