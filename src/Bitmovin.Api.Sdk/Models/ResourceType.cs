using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ResourceType
    /// </summary>
    public enum ResourceType
    {
        /// <summary>
        /// ACCOUNT
        /// </summary>
        [EnumMember(Value = "account")]
        ACCOUNT,

        /// <summary>
        /// ENCODING
        /// </summary>
        [EnumMember(Value = "encoding")]
        ENCODING,

        /// <summary>
        /// PLAYER
        /// </summary>
        [EnumMember(Value = "player")]
        PLAYER,

        /// <summary>
        /// ANALYTICS
        /// </summary>
        [EnumMember(Value = "analytics")]
        ANALYTICS
    }
}
