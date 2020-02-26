using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// MediaType
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// VIDEO
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO,

        /// <summary>
        /// AUDIO
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO
    }
}
