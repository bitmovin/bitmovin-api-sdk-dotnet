using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Type of the stream key
    /// </summary>
    public enum StreamKeyType
    {
        /// <summary>
        /// Stream key is persistent and can be reused. It can be assigned to a live encoding when it is currently not in use
        /// </summary>
        [EnumMember(Value = "RESERVED")]
        RESERVED,

        /// <summary>
        /// Stream key is automatically generated for a live encoding. They can not be reused. After the encoding is finished, the stream key will be gone also
        /// </summary>
        [EnumMember(Value = "TEMPORARY")]
        TEMPORARY
    }
}
