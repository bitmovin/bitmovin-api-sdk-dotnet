using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StaticIpStatus
    /// </summary>
    public enum StaticIpStatus
    {
        /// <summary>
        /// CREATING
        /// </summary>
        [EnumMember(Value = "CREATING")]
        CREATING,

        /// <summary>
        /// UNUSED
        /// </summary>
        [EnumMember(Value = "UNUSED")]
        UNUSED,

        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR,

        /// <summary>
        /// USED
        /// </summary>
        [EnumMember(Value = "USED")]
        USED
    }
}
