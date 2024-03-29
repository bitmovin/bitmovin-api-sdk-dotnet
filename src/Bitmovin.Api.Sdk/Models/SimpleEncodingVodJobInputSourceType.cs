using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Input source type
    /// </summary>
    public enum SimpleEncodingVodJobInputSourceType
    {
        /// <summary>
        /// Input source type
        /// </summary>
        [EnumMember(Value = "URL")]
        URL,

        /// <summary>
        /// Input source type
        /// </summary>
        [EnumMember(Value = "DIRECT_FILE_UPLOAD")]
        DIRECT_FILE_UPLOAD
    }
}
