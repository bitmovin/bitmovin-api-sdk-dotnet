using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SrtMode
    /// </summary>
    public enum SrtMode
    {
        /// <summary>
        /// LISTENER
        /// </summary>
        [EnumMember(Value = "LISTENER")]
        LISTENER,

        /// <summary>
        /// CALLER
        /// </summary>
        [EnumMember(Value = "CALLER")]
        CALLER
    }
}
