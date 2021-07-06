using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DolbyDigitalLoudnessControlMode
    /// </summary>
    public enum DolbyDigitalLoudnessControlMode
    {
        /// <summary>
        /// The provided &#39;dialnorm&#39; value will be set in DD/DD+ bit-stream metadata. The provided value is assumed to be a correct measure of content loudness. No additional loudness measurement or loudness correction will take place.
        /// </summary>
        [EnumMember(Value = "PASSTHROUGH")]
        PASSTHROUGH,

        /// <summary>
        /// The loudness is corrected with the values provided
        /// </summary>
        [EnumMember(Value = "CORRECTION")]
        CORRECTION
    }
}
