using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SignatureType
    /// </summary>
    public enum SignatureType
    {
        /// <summary>
        /// HMAC
        /// </summary>
        [EnumMember(Value = "HMAC")]
        HMAC
    }
}
