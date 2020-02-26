using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashRepresentationType
    /// </summary>
    public enum DashRepresentationType
    {
        /// <summary>
        /// Generates a SegmentTemplate which will be positioned under the representation
        /// </summary>
        [EnumMember(Value = "TEMPLATE")]
        TEMPLATE,

        /// <summary>
        /// Generates a SegmentList based representation
        /// </summary>
        [EnumMember(Value = "LIST")]
        LIST,

        /// <summary>
        /// Generates a SegmentTimeline based representation
        /// </summary>
        [EnumMember(Value = "TIMELINE")]
        TIMELINE
    }
}
