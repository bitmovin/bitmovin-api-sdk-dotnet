using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Defines the mode for weighted prediction for P-frames
    /// </summary>
    public enum WeightedPredictionPFrames
    {
        /// <summary>
        /// Do not keep P-frame references
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,

        /// <summary>
        /// Enable weighted references
        /// </summary>
        [EnumMember(Value = "SIMPLE")]
        SIMPLE,

        /// <summary>
        /// Enable weighted references and duplicates
        /// </summary>
        [EnumMember(Value = "SMART")]
        SMART
    }
}
