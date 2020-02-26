using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Set the maximal CTU (Coding Tree Unit) size
    /// </summary>
    public enum MaxCtuSize
    {
        /// <summary>
        /// Set the maximal CTU (Coding Tree Unit) size
        /// </summary>
        [EnumMember(Value = "16")]
        S16,

        /// <summary>
        /// Set the maximal CTU (Coding Tree Unit) size
        /// </summary>
        [EnumMember(Value = "32")]
        S32,

        /// <summary>
        /// Set the maximal CTU (Coding Tree Unit) size
        /// </summary>
        [EnumMember(Value = "64")]
        S64
    }
}
