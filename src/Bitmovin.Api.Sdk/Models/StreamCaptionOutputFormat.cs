using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamCaptionOutputFormat
    /// </summary>
    public enum StreamCaptionOutputFormat
    {
        /// <summary>
        /// Convert SCC captions to WebVTT format
        /// </summary>
        [EnumMember(Value = "WEBVTT")]
        WEBVTT
    }
}
