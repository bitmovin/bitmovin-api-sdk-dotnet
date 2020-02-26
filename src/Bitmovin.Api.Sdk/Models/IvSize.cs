using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// IvSize
    /// </summary>
    public enum IvSize
    {
        /// <summary>
        /// Define initialization vector to have a size of 8 bytes
        /// </summary>
        [EnumMember(Value = "8_BYTES")]
        IV_8_BYTES,

        /// <summary>
        /// Define initialization vector to have a size of 16 bytes
        /// </summary>
        [EnumMember(Value = "16_BYTES")]
        IV_16_BYTES
    }
}
