using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies the OTT loudness mode. If the mode is &#x60;DTSX_OTT_LOUDNESS_DETECT&#x60;, the &#x60;lkfs&#x60; value will be calculated internally and does not need to be provided. A provided &#x60;lkfs&#x60; value will be ignored. For the modes &#x60;DTSX_OTT_LOUDNESS_INPUT&#x60; and &#x60;DTSX_OTT_LOUDNESS_TARGET&#x60; an &#x60;lkfs&#x60; value must be provided by the user. 
    /// </summary>
    public enum OttLoudnessMode
    {
        /// <summary>
        /// Specifies the OTT loudness mode. If the mode is &#x60;DTSX_OTT_LOUDNESS_DETECT&#x60;, the &#x60;lkfs&#x60; value will be calculated internally and does not need to be provided. A provided &#x60;lkfs&#x60; value will be ignored. For the modes &#x60;DTSX_OTT_LOUDNESS_INPUT&#x60; and &#x60;DTSX_OTT_LOUDNESS_TARGET&#x60; an &#x60;lkfs&#x60; value must be provided by the user. 
        /// </summary>
        [EnumMember(Value = "DTSX_OTT_LOUDNESS_DETECT")]
        DTSX_OTT_LOUDNESS_DETECT,

        /// <summary>
        /// Specifies the OTT loudness mode. If the mode is &#x60;DTSX_OTT_LOUDNESS_DETECT&#x60;, the &#x60;lkfs&#x60; value will be calculated internally and does not need to be provided. A provided &#x60;lkfs&#x60; value will be ignored. For the modes &#x60;DTSX_OTT_LOUDNESS_INPUT&#x60; and &#x60;DTSX_OTT_LOUDNESS_TARGET&#x60; an &#x60;lkfs&#x60; value must be provided by the user. 
        /// </summary>
        [EnumMember(Value = "DTSX_OTT_LOUDNESS_INPUT")]
        DTSX_OTT_LOUDNESS_INPUT,

        /// <summary>
        /// Specifies the OTT loudness mode. If the mode is &#x60;DTSX_OTT_LOUDNESS_DETECT&#x60;, the &#x60;lkfs&#x60; value will be calculated internally and does not need to be provided. A provided &#x60;lkfs&#x60; value will be ignored. For the modes &#x60;DTSX_OTT_LOUDNESS_INPUT&#x60; and &#x60;DTSX_OTT_LOUDNESS_TARGET&#x60; an &#x60;lkfs&#x60; value must be provided by the user. 
        /// </summary>
        [EnumMember(Value = "DTSX_OTT_LOUDNESS_TARGET")]
        DTSX_OTT_LOUDNESS_TARGET
    }
}
