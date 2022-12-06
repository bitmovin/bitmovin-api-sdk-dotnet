using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Dolby Vision track&#39;s sample entry name
    /// </summary>
    public enum DolbyVisionTrackSampleEntryName
    {
        /// <summary>
        /// Sets the Dolby Vision track&#39;s sample entry name to &#x60;dvhe&#x60;. This is the default value
        /// </summary>
        [EnumMember(Value = "DVHE")]
        DVHE,

        /// <summary>
        /// Sets the Dolby Vision track&#39;s sample entry name to &#x60;dvh1&#x60;
        /// </summary>
        [EnumMember(Value = "DVH1")]
        DVH1
    }
}
