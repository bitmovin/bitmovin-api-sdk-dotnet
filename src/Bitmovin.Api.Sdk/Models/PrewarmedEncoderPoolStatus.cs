using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PrewarmedEncoderPoolStatus
    /// </summary>
    public enum PrewarmedEncoderPoolStatus
    {
        /// <summary>
        /// STARTED means that the pool is currently running
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,

        /// <summary>
        /// STOPPED means that the pool is currently not running and cannot be used
        /// </summary>
        [EnumMember(Value = "STOPPED")]
        STOPPED
    }
}
