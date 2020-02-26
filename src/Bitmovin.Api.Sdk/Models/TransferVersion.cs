using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// TransferVersion
    /// </summary>
    public enum TransferVersion
    {
        /// <summary>
        /// DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        /// <summary>
        /// POOL
        /// </summary>
        [EnumMember(Value = "POOL")]
        POOL
    }
}
