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
        /// DESede
        /// </summary>
        [EnumMember(Value = "DESede")]
        DESede,

        /// <summary>
        /// Blowfish
        /// </summary>
        [EnumMember(Value = "Blowfish")]
        Blowfish,

        /// <summary>
        /// RSA
        /// </summary>
        [EnumMember(Value = "RSA")]
        RSA
    }
}
