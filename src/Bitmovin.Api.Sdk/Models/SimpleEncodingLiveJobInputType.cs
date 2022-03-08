using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SimpleEncodingLiveJobInputType
    /// </summary>
    public enum SimpleEncodingLiveJobInputType
    {
        /// <summary>
        /// Live encoding with RTMP input
        /// </summary>
        [EnumMember(Value = "RTMP")]
        RTMP,

        /// <summary>
        /// Live encoding with SRT input in listener mode
        /// </summary>
        [EnumMember(Value = "SRT_LISTENER")]
        SRT_LISTENER
    }
}
