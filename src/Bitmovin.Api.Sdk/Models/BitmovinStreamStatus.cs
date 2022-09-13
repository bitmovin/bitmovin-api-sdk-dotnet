using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// BitmovinStreamStatus
    /// </summary>
    public enum BitmovinStreamStatus
    {
        /// <summary>
        /// The Stream is published and can be accessed
        /// </summary>
        [EnumMember(Value = "PUBLISHED")]
        PUBLISHED,

        /// <summary>
        /// The Stream can&#39;t be accessed
        /// </summary>
        [EnumMember(Value = "UNPUBLISHED")]
        UNPUBLISHED
    }
}
