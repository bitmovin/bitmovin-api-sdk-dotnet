using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamsType
    /// </summary>
    public enum StreamsType
    {
        /// <summary>
        /// VIDEO
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO,

        /// <summary>
        /// LIVE
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE
    }
}
