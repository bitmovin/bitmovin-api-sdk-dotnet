using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Can be 5.1 or 5.1.4
    /// </summary>
    public enum DtsXChannelLayout
    {
        /// <summary>
        /// Channel Layout 5.1
        /// </summary>
        [EnumMember(Value = "5.1")]
        CL_5_1,

        /// <summary>
        /// Channel Layout 5.1.4
        /// </summary>
        [EnumMember(Value = "5.1.4")]
        CL_5_1_4
    }
}
