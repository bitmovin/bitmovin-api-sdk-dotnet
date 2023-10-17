using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// platform which initiated the creation of the resource
    /// </summary>
    public enum SignupSource
    {
        /// <summary>
        /// platform which initiated the creation of the resource
        /// </summary>
        [EnumMember(Value = "AWS")]
        AWS,

        /// <summary>
        /// platform which initiated the creation of the resource
        /// </summary>
        [EnumMember(Value = "AZURE")]
        AZURE,

        /// <summary>
        /// platform which initiated the creation of the resource
        /// </summary>
        [EnumMember(Value = "BITMOVIN")]
        BITMOVIN,

        /// <summary>
        /// platform which initiated the creation of the resource
        /// </summary>
        [EnumMember(Value = "GOOGLE")]
        GOOGLE
    }
}
