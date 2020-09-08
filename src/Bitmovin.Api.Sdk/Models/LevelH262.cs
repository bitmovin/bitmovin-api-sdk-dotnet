using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
    /// </summary>
    public enum LevelH262
    {
        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "MAIN")]
        MAIN,

        /// <summary>
        /// Specified set of constraints that indicate a degree of required decoder performance for a profile, see: https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC#Levels
        /// </summary>
        [EnumMember(Value = "HIGH")]
        HIGH
    }
}
