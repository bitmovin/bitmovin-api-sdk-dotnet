using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Id3TagPositionMode
    /// </summary>
    public enum Id3TagPositionMode
    {
        /// <summary>
        /// TIME
        /// </summary>
        [EnumMember(Value = "TIME")]
        TIME,

        /// <summary>
        /// FRAME
        /// </summary>
        [EnumMember(Value = "FRAME")]
        FRAME
    }
}
