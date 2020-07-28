using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DolbyAtmosInputFormat
    /// </summary>
    public enum DolbyAtmosInputFormat
    {
        /// <summary>
        /// Dolby Atmos input format is DAMF (Dolby Atmos Master Format), usually a .atmos file. The &#39;metadata&#39; and &#39;audio&#39; files referenced within this file need to reside in the same directory and will be resolved automatically.
        /// </summary>
        [EnumMember(Value = "DAMF")]
        DAMF,

        /// <summary>
        /// Dolby Atmos input format is ADM (Audio Definition Model), usually a .wav file
        /// </summary>
        [EnumMember(Value = "ADM")]
        ADM
    }
}
