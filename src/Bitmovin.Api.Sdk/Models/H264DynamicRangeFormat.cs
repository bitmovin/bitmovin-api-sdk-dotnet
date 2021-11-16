using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Ouput should be in Standard Definition Range (SDR).
    /// </summary>
    public enum H264DynamicRangeFormat
    {
        /// <summary>
        /// Ouput should be in Standard Definition Range (SDR).
        /// </summary>
        [EnumMember(Value = "SDR")]
        SDR
    }
}
