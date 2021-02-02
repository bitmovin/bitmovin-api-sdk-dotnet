using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// WebVttCueIdentifierPolicy
    /// </summary>
    public enum WebVttCueIdentifierPolicy
    {
        /// <summary>
        /// Cue identifiers are added in the resulting webvtt file
        /// </summary>
        [EnumMember(Value = "INCLUDE_IDENTIFIERS")]
        INCLUDE_IDENTIFIERS,

        /// <summary>
        /// Cue identifiers are not added in the resulting webvtt file
        /// </summary>
        [EnumMember(Value = "OMIT_IDENTIFIERS")]
        OMIT_IDENTIFIERS
    }
}
