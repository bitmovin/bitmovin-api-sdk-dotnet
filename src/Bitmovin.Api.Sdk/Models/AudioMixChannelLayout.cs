using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Channel layout of this audio mix
    /// </summary>
    public enum AudioMixChannelLayout
    {
        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "MONO")]
        CL_MONO,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "STEREO")]
        CL_STEREO,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "SURROUND")]
        CL_SURROUND,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "QUAD")]
        CL_QUAD,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "OCTAGONAL")]
        CL_OCTAGONAL,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "HEXAGONAL")]
        CL_HEXAGONAL,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "STEREO_DOWNMIX")]
        CL_STEREO_DOWNMIX,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "2.1")]
        CL_2_1,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "2.2")]
        CL_2_2,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "3.1")]
        CL_3_1,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "4.0")]
        CL_4_0,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "4.1")]
        CL_4_1,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "5.0")]
        CL_5_0,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "5.1")]
        CL_5_1,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "5.0_BACK")]
        CL_5_0_BACK,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "5.1_BACK")]
        CL_5_1_BACK,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "6.0")]
        CL_6_0,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "6.0_FRONT")]
        CL_6_0_FRONT,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "6.1")]
        CL_6_1,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "6.1_BACK")]
        CL_6_1_BACK,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "6.1_FRONT")]
        CL_6_1_FRONT,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "7.0")]
        CL_7_0,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "7.0_FRONT")]
        CL_7_0_FRONT,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "7.1")]
        CL_7_1,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "7.1_WIDE")]
        CL_7_1_WIDE,

        /// <summary>
        /// Channel layout of this audio mix
        /// </summary>
        [EnumMember(Value = "7.1_WIDE_BACK")]
        CL_7_1_WIDE_BACK
    }
}
