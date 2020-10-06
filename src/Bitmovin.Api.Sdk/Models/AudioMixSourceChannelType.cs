using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Type of this source channel
    /// </summary>
    public enum AudioMixSourceChannelType
    {
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "CHANNEL_NUMBER")]
        CHANNEL_NUMBER,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "FRONT_LEFT")]
        FRONT_LEFT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "FRONT_RIGHT")]
        FRONT_RIGHT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "CENTER")]
        CENTER,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "LOW_FREQUENCY")]
        LOW_FREQUENCY,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "BACK_LEFT")]
        BACK_LEFT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "BACK_RIGHT")]
        BACK_RIGHT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "SURROUND_LEFT")]
        SURROUND_LEFT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "SURROUND_RIGHT")]
        SURROUND_RIGHT
    }
}
