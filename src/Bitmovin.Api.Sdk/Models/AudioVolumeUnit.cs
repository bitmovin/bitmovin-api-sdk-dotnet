using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The unit in which the audio volume should be changed
    /// </summary>
    public enum AudioVolumeUnit
    {
        /// <summary>
        /// Change the audio volume in percent, e.g., volume 100 will leave the audio volume unchanged, volume 50 will halve the audio volume.
        /// </summary>
        [EnumMember(Value = "PERCENT")]
        PERCENT,

        /// <summary>
        /// Change the audio volume in decibels. E.g., volume 4 will increase audio volume by 4 decibels.
        /// </summary>
        [EnumMember(Value = "DB")]
        DB
    }
}
