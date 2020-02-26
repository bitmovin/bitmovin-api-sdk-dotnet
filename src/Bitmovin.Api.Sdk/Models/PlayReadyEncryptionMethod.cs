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
        MPEGCENC,

        /// <summary>
        /// Encryption method
        /// </summary>
        [EnumMember(Value = "PIFF_CTR")]
        PIFFCTR
    }
}
