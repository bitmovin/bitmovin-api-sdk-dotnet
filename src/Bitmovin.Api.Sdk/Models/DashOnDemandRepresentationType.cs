using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashOnDemandRepresentationType
    /// </summary>
    public enum DashOnDemandRepresentationType
    {
        /// <summary>
        /// Generates a SegmentBase representation
        /// </summary>
        [EnumMember(Value = "SEGMENT_BASE")]
        SEGMENT_BASE,

        /// <summary>
        /// Generates a SegmentList representation
        /// </summary>
        [EnumMember(Value = "SEGMENT_LIST")]
        SEGMENT_LIST
    }
}
