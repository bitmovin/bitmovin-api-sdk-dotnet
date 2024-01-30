using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Status of the stream key
    /// </summary>
    public enum StreamKeyStatus
    {
        /// <summary>
        /// Stream key is assigned to a live encoding.  This means, it **can not be assigned** to a RedundantRtmpInput at the moment. It will be set to UNASSIGNED if the live encoding is finished or in error state
        /// </summary>
        [EnumMember(Value = "ASSIGNED")]
        ASSIGNED,

        /// <summary>
        /// Stream key is not assigned to a live encoding.  This means, that it **is available** to be used with a RedundantRtmpInput
        /// </summary>
        [EnumMember(Value = "UNASSIGNED")]
        UNASSIGNED
    }
}
