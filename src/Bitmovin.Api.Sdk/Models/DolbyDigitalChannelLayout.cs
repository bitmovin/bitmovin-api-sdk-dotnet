using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DolbyDigitalChannelLayout
    /// </summary>
    public enum DolbyDigitalChannelLayout
    {
        /// <summary>
        /// No channel layout
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Channel layout Mono
        /// </summary>
        [EnumMember(Value = "MONO")]
        MONO,

        /// <summary>
        /// Channel layout Stereo
        /// </summary>
        [EnumMember(Value = "STEREO")]
        CL_STEREO,

        /// <summary>
        /// Channel layout 3.0 (3 front (left + center + right), no LFE)
        /// </summary>
        [EnumMember(Value = "SURROUND")]
        CL_SURROUND,

        /// <summary>
        /// Channel layout 3.1 (3 front (left + center + right), LFE)
        /// </summary>
        [EnumMember(Value = "3.1")]
        CL_3_1,

        /// <summary>
        /// Channel layout Surround (2 front (left + right), 1 back center, no LFE)
        /// </summary>
        [EnumMember(Value = "BACK_SURROUND")]
        CL_BACK_SURROUND,

        /// <summary>
        /// Channel layout Surround with LFE (2 front (left + right), 1 back center, LFE)
        /// </summary>
        [EnumMember(Value = "BACK_SURROUND_LFE")]
        CL_BACK_SURROUND_LFE,

        /// <summary>
        /// Channel layout Quad (2 front (left + right), 2 back (left + right), no LFE)
        /// </summary>
        [EnumMember(Value = "QUAD")]
        CL_QUAD,

        /// <summary>
        /// Channel layout Quad with LFE (2 front (left + right), 2 back (left + right), LFE)
        /// </summary>
        [EnumMember(Value = "QUAD_LFE")]
        CL_QUAD_LFE,

        /// <summary>
        /// Channel layout 4.0 (3 front (left + center + right), 1 back center, no LFE)
        /// </summary>
        [EnumMember(Value = "4.0")]
        CL_4_0,

        /// <summary>
        /// Channel layout 4.1 (3 front (left + center + right), 1 back center, LFE)
        /// </summary>
        [EnumMember(Value = "4.1")]
        CL_4_1,

        /// <summary>
        /// Channel layout 5.0 (3 front (left + center + right), 2 side (left + right), no LFE)
        /// </summary>
        [EnumMember(Value = "5.0")]
        CL_5_0,

        /// <summary>
        /// Channel layout 5.1 (3 front (left + center + right), 2 side (left + right), LFE)
        /// </summary>
        [EnumMember(Value = "5.1")]
        CL_5_1
    }
}
