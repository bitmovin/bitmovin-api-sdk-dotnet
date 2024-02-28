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
        CONNECTION_STATUS_JUST_CHANGED
    }
}
