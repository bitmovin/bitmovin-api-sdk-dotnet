using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamsEncodingProfile
    /// </summary>
    public enum StreamsEncodingProfile
    {
        /// <summary>
        /// PER_TITLE
        /// </summary>
        [EnumMember(Value = "PER_TITLE")]
        PER_TITLE,

        /// <summary>
        /// FIXED_RESOLUTIONS
        /// </summary>
        [EnumMember(Value = "FIXED_RESOLUTIONS")]
        FIXED_RESOLUTIONS
    }
}
