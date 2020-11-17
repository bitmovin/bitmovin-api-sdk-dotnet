using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// PrewarmedEncoderDiskSize
    /// </summary>
    public enum PrewarmedEncoderDiskSize
    {
        /// <summary>
        /// GB_500
        /// </summary>
        [EnumMember(Value = "500")]
        GB_500,

        /// <summary>
        /// GB_1000
        /// </summary>
        [EnumMember(Value = "1000")]
        GB_1000,

        /// <summary>
        /// GB_2000
        /// </summary>
        [EnumMember(Value = "2000")]
        GB_2000
    }
}
