using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// –3 dB attenuation can be used to reduce the levels of the surround channels to compensate between the calibration of film dubbing stages and consumer replay environments. The surround channels in film studios are set 3 dB lower than the front channels (unlike consumer applications of 5.1), leading to the level on tape being 3 dB higher. Apply the 3 dB attenuation when using a master mixed in a film room. 
    /// </summary>
    public enum DolbyDigitalPlusThreeDbAttenuation
    {
        /// <summary>
        /// Enable 3 dB attenuation
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// Disable 3 dB attenuation
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
    }
}
