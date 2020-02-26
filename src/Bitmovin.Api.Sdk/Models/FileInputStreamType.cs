using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// FileInputStreamType
    /// </summary>
    public enum FileInputStreamType
    {
        /// <summary>
        /// Specifies that the Sidecar file conforms to the TTML standard
        /// </summary>
        [EnumMember(Value = "TTML")]
        TTML,

        /// <summary>
        /// Specifies that the Sidecar file conforms to the WEBVTT standard
        /// </summary>
        [EnumMember(Value = "WEBVTT")]
        WEBVTT
    }
}
