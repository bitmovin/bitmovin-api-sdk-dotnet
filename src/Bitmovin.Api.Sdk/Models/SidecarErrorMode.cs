using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SidecarErrorMode
    /// </summary>
    public enum SidecarErrorMode
    {
        /// <summary>
        /// If the transfer of the sidecar file fails, the whole encoding will fail
        /// </summary>
        [EnumMember(Value = "FAIL_ON_ERROR")]
        FAIL_ON_ERROR,

        /// <summary>
        /// If the transfer of the sidecar file fails, there is only a warning and the encoding will still continue
        /// </summary>
        [EnumMember(Value = "CONTINUE_ON_ERROR")]
        CONTINUE_ON_ERROR
    }
}
