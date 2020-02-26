using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Signal hypothetical reference decoder (HRD) information (requires bufsize to be set)
    /// </summary>
    public enum H264NalHrd
    {
        /// <summary>
        /// Do not signal HRD information
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Signal HRD for variable bitrate
        /// </summary>
        [EnumMember(Value = "VBR")]
        VBR,

        /// <summary>
        /// Signal HRD for constant bitrate (Not possible with fragmented or progressive MP4 muxings)
        /// </summary>
        [EnumMember(Value = "CBR")]
        CBR
    }
}
