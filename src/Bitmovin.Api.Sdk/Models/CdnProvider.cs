using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// CdnProvider
    /// </summary>
    public enum CdnProvider
    {
        /// <summary>
        /// AKAMAI
        /// </summary>
        [EnumMember(Value = "AKAMAI")]
        AKAMAI,

        /// <summary>
        /// AWS
        /// </summary>
        [EnumMember(Value = "AWS")]
        AWS
    }
}
