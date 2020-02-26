using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// StreamMode
    /// </summary>
    public enum StreamMode
    {
        /// <summary>
        /// Standard encoding. This is used to configure renditions that must show up in the output, i.e. will get encoded exactly as configured.
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        STANDARD,

        /// <summary>
        /// Template for Per-Title encoding. This is used to define encoding settings for a given resolution when Per-Title encoding is enabled. Additionally, it allows to define which resolutions should be considered by Per-Title encoding.
        /// </summary>
        [EnumMember(Value = "PER_TITLE_TEMPLATE")]
        PER_TITLE_TEMPLATE,

        /// <summary>
        /// Same as PER_TITLE_TEMPLATE, but it will be ensured that the configured resolution will be present in the Per-Title result.
        /// </summary>
        [EnumMember(Value = "PER_TITLE_TEMPLATE_FIXED_RESOLUTION")]
        PER_TITLE_TEMPLATE_FIXED_RESOLUTION,

        /// <summary>
        /// Same as PER_TITLE_TEMPLATE, but it will be ensured that the configured resolution and bitrate range will be present in the Per-Title result.
        /// </summary>
        [EnumMember(Value = "PER_TITLE_TEMPLATE_FIXED_RESOLUTION_AND_BITRATE")]
        PER_TITLE_TEMPLATE_FIXED_RESOLUTION_AND_BITRATE,

        /// <summary>
        /// Once the Per-Title encoding is done, the generated streams will have this mode set.
        /// </summary>
        [EnumMember(Value = "PER_TITLE_RESULT")]
        PER_TITLE_RESULT
    }
}
