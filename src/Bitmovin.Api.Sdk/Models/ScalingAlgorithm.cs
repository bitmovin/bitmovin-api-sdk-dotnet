using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Determines the algorithm used for scaling
    /// </summary>
    public enum ScalingAlgorithm
    {
        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "FAST_BILINEAR")]
        FAST_BILINEAR,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "BILINEAR")]
        BILINEAR,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "BICUBIC")]
        BICUBIC,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "EXPERIMENTAL")]
        EXPERIMENTAL,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "NEAREST_NEIGHBOR")]
        NEAREST_NEIGHBOR,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "AVERAGING_AREA")]
        AVERAGING_AREA,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "BICUBIC_LUMA_BILINEAR_CHROMA")]
        BICUBIC_LUMA_BILINEAR_CHROMA,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "GAUSS")]
        GAUSS,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "SINC")]
        SINC,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "LANCZOS")]
        LANCZOS,

        /// <summary>
        /// Determines the algorithm used for scaling
        /// </summary>
        [EnumMember(Value = "SPLINE")]
        SPLINE
    }
}
