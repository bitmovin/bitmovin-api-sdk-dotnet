using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// A 90° phase shift can be applied to the surround channels during encoding. This is useful for generating multichannel bitstreams which, when downmixed, can create a true Dolby Surround compatible output (Left/Right) 
    /// </summary>
    public enum DolbyDigitalPlusNinetyDegreePhaseShift
    {
        /// <summary>
        /// Enable 90° phase shift
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// Disable 90° phase shift
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED
    }
}
