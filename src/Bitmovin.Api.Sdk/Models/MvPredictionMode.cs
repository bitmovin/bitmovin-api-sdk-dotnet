using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Sets the Motion Vector Prediction Mode.
    /// </summary>
    public enum MvPredictionMode
    {
        /// <summary>
        /// Sets the Motion Vector Prediction Mode.
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Sets the Motion Vector Prediction Mode.
        /// </summary>
        [EnumMember(Value = "SPATIAL")]
        SPATIAL,

        /// <summary>
        /// Sets the Motion Vector Prediction Mode.
        /// </summary>
        [EnumMember(Value = "TEMPORAL")]
        TEMPORAL,

        /// <summary>
        /// Sets the Motion Vector Prediction Mode.
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO
    }
}
