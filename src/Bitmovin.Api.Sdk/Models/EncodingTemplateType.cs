using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// The Encoding Template type
    /// </summary>
    public enum EncodingTemplateType
    {
        /// <summary>
        /// VOD Encoding Template
        /// </summary>
        [EnumMember(Value = "VOD")]
        VOD,

        /// <summary>
        /// Live Encoding Template
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE
    }
}
