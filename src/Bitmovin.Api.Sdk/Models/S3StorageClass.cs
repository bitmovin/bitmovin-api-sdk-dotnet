using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// S3StorageClass
    /// </summary>
    public enum S3StorageClass
    {
        /// <summary>
        /// GLACIER_IR
        /// </summary>
        [EnumMember(Value = "GLACIER_IR")]
        GLACIER_IR,

        /// <summary>
        /// INTELLIGENT_TIERING
        /// </summary>
        [EnumMember(Value = "INTELLIGENT_TIERING")]
        INTELLIGENT_TIERING,

        /// <summary>
        /// ONEZONE_IA
        /// </summary>
        [EnumMember(Value = "ONEZONE_IA")]
        ONEZONE_IA,

        /// <summary>
        /// REDUCED_REDUNDANCY
        /// </summary>
        [EnumMember(Value = "REDUCED_REDUNDANCY")]
        REDUCED_REDUNDANCY,

        /// <summary>
        /// STANDARD
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        STANDARD,

        /// <summary>
        /// STANDARD_IA
        /// </summary>
        [EnumMember(Value = "STANDARD_IA")]
        STANDARD_IA
    }
}
