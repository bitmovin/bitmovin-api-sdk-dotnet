using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Output type
    /// </summary>
    public enum SimpleEncodingLiveJobOutputType
    {
        /// <summary>
        /// Output type
        /// </summary>
        [EnumMember(Value = "URL")]
        URL,

        /// <summary>
        /// Output type
        /// </summary>
        [EnumMember(Value = "CDN")]
        CDN
    }
}
