using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Low frequency effects low pass filter
    /// </summary>
    public enum DolbyDigitalPlusLfeLowPassFilter
    {
        /// <summary>
        /// Enable low frequency effects low pass filter
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// Disable low frequency effects low pass filter
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
    }
}
