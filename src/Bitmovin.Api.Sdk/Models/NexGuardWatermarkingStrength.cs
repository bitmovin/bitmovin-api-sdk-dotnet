using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// NexGuardWatermarkingStrength
    /// </summary>
    public enum NexGuardWatermarkingStrength
    {
        /// <summary>
        /// LIGHTEST
        /// </summary>
        [EnumMember(Value = "LIGHTEST")]
        LIGHTEST,

        /// <summary>
        /// LIGHTER
        /// </summary>
        [EnumMember(Value = "LIGHTER")]
        LIGHTER,

        /// <summary>
        /// DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        /// <summary>
        /// STRONGER
        /// </summary>
        [EnumMember(Value = "STRONGER")]
        STRONGER,

        /// <summary>
        /// STRONGEST
        /// </summary>
        [EnumMember(Value = "STRONGEST")]
        STRONGEST
    }
}
