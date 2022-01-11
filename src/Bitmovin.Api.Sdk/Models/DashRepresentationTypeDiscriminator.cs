using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashRepresentationTypeDiscriminator
    /// </summary>
    public enum DashRepresentationTypeDiscriminator
    {
        /// <summary>
        /// DRM_FMP4
        /// </summary>
        [EnumMember(Value = "DRM_FMP4")]
        DRM_FMP4,

        /// <summary>
        /// FMP4
        /// </summary>
        [EnumMember(Value = "FMP4")]
        FMP4,

        /// <summary>
        /// WEBM
        /// </summary>
        [EnumMember(Value = "WEBM")]
        WEBM,

        /// <summary>
        /// CMAF
        /// </summary>
        [EnumMember(Value = "CMAF")]
        CMAF,

        /// <summary>
        /// CHUNKED_TEXT
        /// </summary>
        [EnumMember(Value = "CHUNKED_TEXT")]
        CHUNKED_TEXT,

        /// <summary>
        /// MP4
        /// </summary>
        [EnumMember(Value = "MP4")]
        MP4,

        /// <summary>
        /// DRM_MP4
        /// </summary>
        [EnumMember(Value = "DRM_MP4")]
        DRM_MP4,

        /// <summary>
        /// PROGRESSIVE_WEBM
        /// </summary>
        [EnumMember(Value = "PROGRESSIVE_WEBM")]
        PROGRESSIVE_WEBM,

        /// <summary>
        /// VTT
        /// </summary>
        [EnumMember(Value = "VTT")]
        VTT,

        /// <summary>
        /// SPRITE
        /// </summary>
        [EnumMember(Value = "SPRITE")]
        SPRITE,

        /// <summary>
        /// IMSC
        /// </summary>
        [EnumMember(Value = "IMSC")]
        IMSC,

        /// <summary>
        /// CONTENT_PROTECTION
        /// </summary>
        [EnumMember(Value = "CONTENT_PROTECTION")]
        CONTENT_PROTECTION
    }
}
