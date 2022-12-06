using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Motion vector prediction mode
    /// </summary>
    public enum MvPredictionMode
    {
        /// <summary>
        /// Motion vector prediction mode
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Motion vector prediction mode
        /// </summary>
        [EnumMember(Value = "SPATIAL")]
        SPATIAL,

        /// <summary>
        /// Motion vector prediction mode
        /// </summary>
        [EnumMember(Value = "TEMPORAL")]
        TEMPORAL,

        /// <summary>
        /// Motion vector prediction mode
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO
    }
}
