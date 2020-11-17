using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PrewarmedEncoderPoolAction
    /// </summary>
    public enum PrewarmedEncoderPoolAction
    {
        /// <summary>
        /// START
        /// </summary>
        [EnumMember(Value = "START")]
        START,

        /// <summary>
        /// STOP
        /// </summary>
        [EnumMember(Value = "STOP")]
        STOP
    }
}
