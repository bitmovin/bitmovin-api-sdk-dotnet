using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// H265V2PerceptualEncodingMode
    /// </summary>
    public enum H265V2PerceptualEncodingMode
    {
        /// <summary>
        /// Perceptual encoding disabled
        /// </summary>
        [EnumMember(Value = "OFF")]
        OFF,

        /// <summary>
        /// HVS-based perceptual encoding using CU delta QP
        /// </summary>
        [EnumMember(Value = "CU_DELTA_QP")]
        CU_DELTA_QP
    }
}
