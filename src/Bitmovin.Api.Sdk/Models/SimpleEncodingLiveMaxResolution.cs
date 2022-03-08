using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SimpleEncodingLiveMaxResolution
    /// </summary>
    public enum SimpleEncodingLiveMaxResolution
    {
        /// <summary>
        /// FULL_HD
        /// </summary>
        [EnumMember(Value = "FULL_HD")]
        FULL_HD,

        /// <summary>
        /// HD
        /// </summary>
        [EnumMember(Value = "HD")]
        HD,

        /// <summary>
        /// SD
        /// </summary>
        [EnumMember(Value = "SD")]
        SD
    }
}
