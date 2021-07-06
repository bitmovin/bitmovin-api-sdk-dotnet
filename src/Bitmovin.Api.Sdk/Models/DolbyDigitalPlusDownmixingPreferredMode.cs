using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// It indicates if downmixing mode is Dolby Surround compatible (&#x60;LT_RT&#x60;: Left total/Right total) or Dolby Pro Logic II (&#x60;PRO_LOGIC_II&#x60;).  &#x60;LO_RO&#x60; for Left only/Right only: A downmix from a multichannel to a two‐channel output that is compatible for stereo or mono reproduction. 
    /// </summary>
    public enum DolbyDigitalPlusDownmixingPreferredMode
    {
        /// <summary>
        /// Lo/Ro stereo downmixing mode
        /// </summary>
        [EnumMember(Value = "LO_RO")]
        LO_RO,

        /// <summary>
        /// Lt/Rt surround downmixing mode
        /// </summary>
        [EnumMember(Value = "LT_RT")]
        LT_RT,

        /// <summary>
        /// Dolby Pro Logic 2 downmixing mode
        /// </summary>
        [EnumMember(Value = "PRO_LOGIC_II")]
        PRO_LOGIC_II
    }
}
