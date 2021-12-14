using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdaptationSetType
    /// </summary>
    public enum AdaptationSetType
    {
        /// <summary>
        /// VIDEO
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        VIDEO,

        /// <summary>
        /// AUDIO
        /// </summary>
        [EnumMember(Value = "AUDIO")]
        AUDIO,

        /// <summary>
        /// IMAGE
        /// </summary>
        [EnumMember(Value = "IMAGE")]
        IMAGE,

        /// <summary>
        /// SUBTITLE
        /// </summary>
        [EnumMember(Value = "SUBTITLE")]
        SUBTITLE
    }
}
