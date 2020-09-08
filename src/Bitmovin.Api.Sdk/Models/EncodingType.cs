using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// EncodingType
    /// </summary>
    public enum EncodingType
    {
        /// <summary>
        /// Live Encoding
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE,

        /// <summary>
        /// VOD Encoding
        /// </summary>
        [EnumMember(Value = "VOD")]
        VOD,

        /// <summary>
        /// Type of an Encoding which has not yet been started
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE
    }
}
