using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Specifies whether to use path or virtual-hosted style access
    /// </summary>
    public enum S3AccessStyle
    {
        /// <summary>
        /// virtual-hosted style (example: bucket-name.s3.example.com)
        /// </summary>
        [EnumMember(Value = "VIRTUAL_HOSTED")]
        VIRTUAL_HOSTED,

        /// <summary>
        /// path style (example: s3.example.com/bucket-name)
        /// </summary>
        [EnumMember(Value = "PATH")]
        PATH
    }
}
