using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AkamaiMslVersion
    /// </summary>
    public enum AkamaiMslVersion
    {
        /// <summary>
        /// MSL4
        /// </summary>
        [EnumMember(Value = "MSL4")]
        MSL4,

        /// <summary>
        /// MSL5
        /// </summary>
        [EnumMember(Value = "MSL5")]
        MSL5
    }
}
