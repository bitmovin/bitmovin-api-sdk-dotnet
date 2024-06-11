using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AzureSpeechToCaptionsProfanity
    /// </summary>
    public enum AzureSpeechToCaptionsProfanity
    {
        /// <summary>
        /// MASKED
        /// </summary>
        [EnumMember(Value = "MASKED")]
        MASKED,

        /// <summary>
        /// REMOVED
        /// </summary>
        [EnumMember(Value = "REMOVED")]
        REMOVED,

        /// <summary>
        /// RAW
        /// </summary>
        [EnumMember(Value = "RAW")]
        RAW
    }
}
