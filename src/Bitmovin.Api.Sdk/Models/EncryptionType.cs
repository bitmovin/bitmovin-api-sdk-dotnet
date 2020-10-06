using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// EncryptionType
    /// </summary>
    public enum EncryptionType
    {
        /// <summary>
        /// AES
        /// </summary>
        [EnumMember(Value = "AES")]
        AES,

        /// <summary>
        /// DESEDE
        /// </summary>
        [EnumMember(Value = "DESede")]
        DESEDE,

        /// <summary>
        /// BLOWFISH
        /// </summary>
        [EnumMember(Value = "Blowfish")]
        BLOWFISH,

        /// <summary>
        /// RSA
        /// </summary>
        [EnumMember(Value = "RSA")]
        RSA
    }
}
