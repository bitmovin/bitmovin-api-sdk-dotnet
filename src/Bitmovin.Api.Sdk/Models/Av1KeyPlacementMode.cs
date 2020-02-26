using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies whether keyframes should be placed at fixed intervals or the encoder may determine optimal placement automatically
    /// </summary>
    public enum Av1KeyPlacementMode
    {
        /// <summary>
        /// Specifies whether keyframes should be placed at fixed intervals or the encoder may determine optimal placement automatically
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// Specifies whether keyframes should be placed at fixed intervals or the encoder may determine optimal placement automatically
        /// </summary>
        [EnumMember(Value = "FIXED")]
        FIXED,

        /// <summary>
        /// Specifies whether keyframes should be placed at fixed intervals or the encoder may determine optimal placement automatically
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
    }
}
