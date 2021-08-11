using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsHttpRequestType
    /// </summary>
    public enum AnalyticsHttpRequestType
    {
        /// <summary>
        /// DRM_LICENSE_WIDEVINE
        /// </summary>
        [EnumMember(Value = "DRM_LICENSE_WIDEVINE,")]
        DRM_LICENSE_WIDEVINE,

        /// <summary>
        /// MEDIA_THUMBNAILS
        /// </summary>
        [EnumMember(Value = "MEDIA_THUMBNAILS,")]
        MEDIA_THUMBNAILS,

        /// <summary>
        /// MEDIA_VIDEO
        /// </summary>
        [EnumMember(Value = "MEDIA_VIDEO,")]
        MEDIA_VIDEO,

        /// <summary>
        /// MEDIA_AUDIO
        /// </summary>
        [EnumMember(Value = "MEDIA_AUDIO,")]
        MEDIA_AUDIO,

        /// <summary>
        /// MEDIA_PROGRESSIVE
        /// </summary>
        [EnumMember(Value = "MEDIA_PROGRESSIVE,")]
        MEDIA_PROGRESSIVE,

        /// <summary>
        /// MEDIA_SUBTITLES
        /// </summary>
        [EnumMember(Value = "MEDIA_SUBTITLES,")]
        MEDIA_SUBTITLES,

        /// <summary>
        /// MANIFEST_DASH
        /// </summary>
        [EnumMember(Value = "MANIFEST_DASH,")]
        MANIFEST_DASH,

        /// <summary>
        /// MANIFEST_HLS_MASTER
        /// </summary>
        [EnumMember(Value = "MANIFEST_HLS_MASTER,")]
        MANIFEST_HLS_MASTER,

        /// <summary>
        /// MANIFEST_HLS_VARIANT
        /// </summary>
        [EnumMember(Value = "MANIFEST_HLS_VARIANT,")]
        MANIFEST_HLS_VARIANT,

        /// <summary>
        /// MANIFEST_SMOOTH
        /// </summary>
        [EnumMember(Value = "MANIFEST_SMOOTH,")]
        MANIFEST_SMOOTH,

        /// <summary>
        /// KEY_HLS_AES
        /// </summary>
        [EnumMember(Value = "KEY_HLS_AES,")]
        KEY_HLS_AES,

        /// <summary>
        /// UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN
    }
}
