using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashEditionCompatibility
    /// </summary>
    public enum DashEditionCompatibility
    {
        /// <summary>
        /// States the compatibility of the DASH manifest with the standard DASH Edition. When set to V4, the endNumber attribute will be automatically added to the last Media Segment in the Representation of the Period, in order to improve playback compatibility. If the property is not set the endNumber attribute tag will not be added.
        /// </summary>
        [EnumMember(Value = "V4")]
        V4
    }
}
