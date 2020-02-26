using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ResponseStatus
    /// </summary>
    public enum ResponseStatus
    {
        /// <summary>
        /// SUCCESS
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        /// <summary>
        /// ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }
}
