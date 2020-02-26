using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Detailed encryption method
    /// </summary>
    public enum AesEncryptionMethod
    {
        /// <summary>
        /// Detailed encryption method
        /// </summary>
        [EnumMember(Value = "SAMPLE_AES")]
        SAMPLEAES,

        /// <summary>
        /// Detailed encryption method
        /// </summary>
        [EnumMember(Value = "AES_128")]
        AES128
    }
}
