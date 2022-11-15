using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamsVideoStatus
    /// </summary>
    public enum StreamsVideoStatus
    {
        /// <summary>
        /// The stream is published and can be accessed
        /// </summary>
        [EnumMember(Value = "PUBLISHED")]
        PUBLISHED,

        /// <summary>
        /// The stream cannot be accessed
        /// </summary>
        [EnumMember(Value = "UNPUBLISHED")]
        UNPUBLISHED
    }
}
