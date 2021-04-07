using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies if the Enhanced Deinterlace Filter should be applied unconditionally or only on demand.
    /// </summary>
    public enum EnhancedDeinterlaceAutoEnable
    {
        /// <summary>
        /// The content will always be deinterlaced with the settings specified (mode, parity)
        /// </summary>
        [EnumMember(Value = "ALWAYS_ON")]
        ALWAYS_ON,

        /// <summary>
        /// The Enhanced Deinterlace Filter will only be applied when interlaced content is signaled in the meta data of the input stream.
        /// </summary>
        [EnumMember(Value = "META_DATA_BASED")]
        META_DATA_BASED
    }
}
