using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Encryption method
    /// </summary>
    public enum PlayReadyEncryptionMethod
    {
        /// <summary>
        /// Encryption method
        /// </summary>
        [EnumMember(Value = "MPEG_CENC")]
        MPEG_CENC,

        /// <summary>
        /// Encryption method
        /// </summary>
        [EnumMember(Value = "PIFF_CTR")]
        PIFF_CTR
    }
}
