using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// altref noise reduction filter type
    /// </summary>
    public enum Vp9ArnrType
    {
        /// <summary>
        /// altref noise reduction filter type
        /// </summary>
        [EnumMember(Value = "BACKWARD")]
        BACKWARD,

        /// <summary>
        /// altref noise reduction filter type
        /// </summary>
        [EnumMember(Value = "FORWARD")]
        FORWARD,

        /// <summary>
        /// altref noise reduction filter type
        /// </summary>
        [EnumMember(Value = "CENTERED")]
        CENTERED
    }
}
