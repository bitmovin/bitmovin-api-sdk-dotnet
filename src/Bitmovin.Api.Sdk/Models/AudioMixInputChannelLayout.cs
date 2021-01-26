using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AudioMixInputChannelLayout
    /// </summary>
    public enum AudioMixInputChannelLayout
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
        /// Channel layout Surround
        /// </summary>
        [EnumMember(Value = "SURROUND")]
        CL_SURROUND,

        /// <summary>
        /// Channel layout Quad
        /// </summary>
        [EnumMember(Value = "QUAD")]
        CL_QUAD,

        /// <summary>
        /// Channel layout Hexagonal
        /// </summary>
        [EnumMember(Value = "HEXAGONAL")]
        CL_HEXAGONAL,

        /// <summary>
        /// Channel layout Octagonal
        /// </summary>
        [EnumMember(Value = "OCTAGONAL")]
        CL_OCTAGONAL,

        /// <summary>
        /// Channel layout Stereo Downmix
        /// </summary>
        [EnumMember(Value = "STEREO_DOWNMIX")]
        CL_STEREO_DOWNMIX,

        /// <summary>
        /// Channel layout 2.1
        /// </summary>
        [EnumMember(Value = "2.1")]
        CL_2_1,

        /// <summary>
        /// Channel layout 2.2
        /// </summary>
        [EnumMember(Value = "2.2")]
        CL_2_2,

        /// <summary>
        /// Channel layout 3.1
        /// </summary>
        [EnumMember(Value = "3.1")]
        CL_3_1,

        /// <summary>
        /// Channel layout 4.0
        /// </summary>
        [EnumMember(Value = "4.0")]
        CL_4_0,

        /// <summary>
        /// Channel layout 4.1
        /// </summary>
        [EnumMember(Value = "4.1")]
        CL_4_1,

        /// <summary>
        /// Channel layout 5.0
        /// </summary>
        [EnumMember(Value = "5.0")]
        CL_5_0,

        /// <summary>
        /// Channel layout 5.1
        /// </summary>
        [EnumMember(Value = "5.1")]
        CL_5_1,

        /// <summary>
        /// Channel layout 5.0 Back
        /// </summary>
        [EnumMember(Value = "5.0_BACK")]
        CL_5_0_BACK,

        /// <summary>
        /// Channel layout 5.1 Back
        /// </summary>
        [EnumMember(Value = "5.1_BACK")]
        CL_5_1_BACK,

        /// <summary>
        /// Channel layout 6.0
        /// </summary>
        [EnumMember(Value = "6.0")]
        CL_6_0,

        /// <summary>
        /// Channel layout 6.0 Front
        /// </summary>
        [EnumMember(Value = "6.0_FRONT")]
        CL_6_0_FRONT,

        /// <summary>
        /// Channel layout 6.1
        /// </summary>
        [EnumMember(Value = "6.1")]
        CL_6_1,

        /// <summary>
        /// Channel layout 6.1 Front
        /// </summary>
        [EnumMember(Value = "6.1_FRONT")]
        CL_6_1_FRONT,

        /// <summary>
        /// Channel layout 6.1 Back
        /// </summary>
        [EnumMember(Value = "6.1_BACK")]
        CL_6_1_BACK,

        /// <summary>
        /// Channel layout 7.0
        /// </summary>
        [EnumMember(Value = "7.0")]
        CL_7_0,

        /// <summary>
        /// Channel layout 7.0 Front
        /// </summary>
        [EnumMember(Value = "7.0_FRONT")]
        CL_7_0_FRONT,

        /// <summary>
        /// Channel layout 7.1
        /// </summary>
        [EnumMember(Value = "7.1")]
        CL_7_1,

        /// <summary>
        /// Channel layout 7.1 Wide
        /// </summary>
        [EnumMember(Value = "7.1_WIDE")]
        CL_7_1_WIDE,

        /// <summary>
        /// Channel layout 7.1 Wide Back
        /// </summary>
        [EnumMember(Value = "7.1_WIDE_BACK")]
        CL_7_1_WIDE_BACK
    }
}
