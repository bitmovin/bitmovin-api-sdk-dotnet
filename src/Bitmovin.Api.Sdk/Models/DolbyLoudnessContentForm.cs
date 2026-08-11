using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The form of the content, used to optimize the loudness measurement gating
    /// </summary>
    public enum DolbyLoudnessContentForm
    {
        /// <summary>
        /// Long-form content, i.e. longer than 3 minutes (180 seconds), such as movies or episodes. Uses relative gating for the loudness measurement.
        /// </summary>
        [EnumMember(Value = "LONG")]
        LONG,

        /// <summary>
        /// Short-form content, i.e. 3 minutes (180 seconds) or shorter, such as advertisements or promos. Uses no relative gating for the loudness measurement.
        /// </summary>
        [EnumMember(Value = "SHORT")]
        SHORT,

        /// <summary>
        /// Automatically detect the content form and apply the corresponding gating.
        /// </summary>
        [EnumMember(Value = "AUTO_DETECT")]
        AUTO_DETECT
    }
}
