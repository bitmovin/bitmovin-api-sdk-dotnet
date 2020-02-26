using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SpriteUnit
    /// </summary>
    public enum SpriteUnit
    {
        /// <summary>
        /// Unit of positions is in seconds
        /// </summary>
        [EnumMember(Value = "SECONDS")]
        SECONDS,

        /// <summary>
        /// Unit of positions is in percent
        /// </summary>
        [EnumMember(Value = "PERCENTS")]
        PERCENTS
    }
}
