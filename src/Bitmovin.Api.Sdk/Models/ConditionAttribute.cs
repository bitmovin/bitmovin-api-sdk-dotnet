using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The attribute that should be checked
    /// </summary>
    public enum ConditionAttribute
    {
        /// <summary>
        /// Height of the input
        /// </summary>
        [EnumMember(Value = "HEIGHT")]
        HEIGHT,

        /// <summary>
        /// Width of the input
        /// </summary>
        [EnumMember(Value = "WIDTH")]
        WIDTH,

        /// <summary>
        /// Bitrate of the input
        /// </summary>
        [EnumMember(Value = "BITRATE")]
        BITRATE,

        /// <summary>
        /// Frames per second of the input
        /// </summary>
        [EnumMember(Value = "FPS")]
        FPS,

        /// <summary>
        /// Aspect ratio of the input (greater 1 &#x3D; landscape; smaller 1 &#x3D; portrait)
        /// </summary>
        [EnumMember(Value = "ASPECTRATIO")]
        ASPECTRATIO,

        /// <summary>
        /// Input stream is present (boolean)
        /// </summary>
        [EnumMember(Value = "INPUTSTREAM")]
        INPUTSTREAM,

        /// <summary>
        /// The language of the audio stream (string)
        /// </summary>
        [EnumMember(Value = "LANGUAGE")]
        LANGUAGE,

        /// <summary>
        /// The channel format of the audio stream (string)
        /// </summary>
        [EnumMember(Value = "CHANNELFORMAT")]
        CHANNELFORMAT,

        /// <summary>
        /// The channel layout of the audio stream (integer)
        /// </summary>
        [EnumMember(Value = "CHANNELLAYOUT")]
        CHANNELLAYOUT,

        /// <summary>
        /// The total numbers of streams in the input file (integer)
        /// </summary>
        [EnumMember(Value = "STREAMCOUNT")]
        STREAMCOUNT,

        /// <summary>
        /// The total numbers of audio streams in the input file (integer)
        /// </summary>
        [EnumMember(Value = "AUDIOSTREAMCOUNT")]
        AUDIOSTREAMCOUNT,

        /// <summary>
        /// The total numbers of video streams in the input file (integer)
        /// </summary>
        [EnumMember(Value = "VIDEOSTREAMCOUNT")]
        VIDEOSTREAMCOUNT,

        /// <summary>
        /// The duration of the input file (double)
        /// </summary>
        [EnumMember(Value = "DURATION")]
        DURATION,

        /// <summary>
        /// The rotation of the input file (double)
        /// </summary>
        [EnumMember(Value = "ROTATION")]
        ROTATION,

        /// <summary>
        /// String value representing the changed connection status
        /// </summary>
        [EnumMember(Value = "CONNECTION_STATUS")]
        CONNECTION_STATUS,

        /// <summary>
        /// Boolean value if the connection status changed
        /// </summary>
        [EnumMember(Value = "CONNECTION_STATUS_JUST_CHANGED")]
        CONNECTION_STATUS_JUST_CHANGED,

        /// <summary>
        /// The container-native identifier of the stream (integer). Depending on the container format of the input file, this maps to: - MPEG-TS: the stream&#39;s PID (Packet ID) - ISOBMFF/MOV (e.g. MP4): the stream&#39;s Track ID  Tools such as &#x60;ffprobe&#x60; and &#x60;tsduck&#x60; display these identifiers in hexadecimal (for example, &#x60;Stream #0:0[0x101]&#x60;). The value used for this condition is matched in decimal: PID &#x60;0x101&#x60; corresponds to &#x60;STREAMID &#x3D;&#x3D; 257&#x60;. Hexadecimal values prefixed with &#x60;0x&#x60; are also accepted, so &#x60;STREAMID &#x3D;&#x3D; 0x101&#x60; matches the same stream.
        /// </summary>
        [EnumMember(Value = "STREAMID")]
        STREAMID
    }
}
