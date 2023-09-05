using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Type of signup marketplace
    /// </summary>
    public enum Marketplace
    {
        /// <summary>
        /// AWS marketplace
        /// </summary>
        [EnumMember(Value = "AWS")]
        AWS,

        /// <summary>
        /// Azure marketplace
        /// </summary>
        [EnumMember(Value = "AZURE")]
        AZURE
    }
}
