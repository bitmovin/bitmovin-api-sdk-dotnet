using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies if the deinterlace filter should be applied unconditionally or only on demand.
    /// </summary>
    public enum DeinterlaceAutoEnable
    {
        /// <summary>
        /// The content will always be deinterlaced with the settings specified (mode, parity, frameSelectionMode)
        /// </summary>
        [EnumMember(Value = "ALWAYS_ON")]
        ALWAYS_ON,

        /// <summary>
        /// The deinterlace filter will only be applied when interlaced content is signaled in the meta data of the input stream. In that case, if the parity setting is set to &quot;AUTO&quot;, it will be overwritten with the result of the metadata probing. In cases where parity is not set to &quot;AUTO&quot; the configured value will be used.
        /// </summary>
        [EnumMember(Value = "META_DATA_BASED")]
        META_DATA_BASED,

        /// <summary>
        /// This option will check if the content is signaled as interlaced first. If not, the frames are analyzed to detect interlaced frames. If the content is signaled as interlaced by the meta data this mode works same as &quot;META_DATA_BASED&quot;. If content analysis detects interlaced frames the deinterlace filter will be applied in frameSelectionMode &quot;ALL&quot;. Additionally, the parity will always be overwritten with the result of the metadata probing.
        /// </summary>
        [EnumMember(Value = "META_DATA_AND_CONTENT_BASED")]
        META_DATA_AND_CONTENT_BASED
    }
}
