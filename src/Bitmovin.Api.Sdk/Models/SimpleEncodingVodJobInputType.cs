using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SimpleEncodingVodJobInputType
    /// </summary>
    public enum SimpleEncodingVodJobInputType
    {
        /// <summary>
        /// Indicates that the linked input file contains a video stream
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO,

        /// <summary>
        /// Indicates that the linked input file contains at least one audio stream
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO,

        /// <summary>
        /// Indicates that the linked input file is a subtitle media file
        /// </summary>
        [EnumMember(Value = "SUBTITLES")]
        SUBTITLES,

        /// <summary>
        /// Indicates that the linked input file is a closed caption media file
        /// </summary>
        [EnumMember(Value = "CLOSED_CAPTIONS")]
        CLOSED_CAPTIONS
    }
}
