using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// RegulatoryAdvisoryTopic
    /// </summary>
    public enum RegulatoryAdvisoryTopic
    {
        /// <summary>
        /// Tobacco and vaping imagery, as covered by statutory on-screen advisory requirements such as the Indian Cigarettes and Other Tobacco Products Amendment Rules, 2023. Detected shots are reported per category, distinguishing tobacco from vaping imagery
        /// </summary>
        [EnumMember(Value = "TOBACCO")]
        TOBACCO
    }
}
