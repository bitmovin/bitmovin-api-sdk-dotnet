using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The encryption method to use.
    /// </summary>
    public enum EncryptionMode
    {
        /// <summary>
        /// The encryption method to use.
        /// </summary>
        [EnumMember(Value = "CTR")]
        CTR,

        /// <summary>
        /// The encryption method to use.
        /// </summary>
        [EnumMember(Value = "CBC")]
        CBC
    }
}
