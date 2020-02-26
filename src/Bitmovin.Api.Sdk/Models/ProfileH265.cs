using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ProfileH265
    /// </summary>
    public enum ProfileH265
    {
        /// <summary>
        /// Main profile
        /// </summary>
        [EnumMember(Value = "main")]
        MAIN,

        /// <summary>
        /// Main 10 profile
        /// </summary>
        [EnumMember(Value = "main10")]
        MAIN10
    }
}
