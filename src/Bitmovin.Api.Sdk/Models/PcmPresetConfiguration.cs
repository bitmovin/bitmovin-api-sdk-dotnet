using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PcmPresetConfiguration
    /// </summary>
    public enum PcmPresetConfiguration
    {
        /// <summary>
        /// Preset with 48kHz sampling rate, S24LE sampling format and MONO channel layout.
        /// </summary>
        [EnumMember(Value = "XDCAM")]
        XDCAM
    }
}
