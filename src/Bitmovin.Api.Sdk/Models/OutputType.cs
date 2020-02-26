using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// OutputType
    /// </summary>
    public enum OutputType
    {
        /// <summary>
        /// AKAMAINETSTORAGE
        /// </summary>
        [EnumMember(Value = "AKAMAI_NETSTORAGE")]
        AKAMAINETSTORAGE,

        /// <summary>
        /// AZURE
        /// </summary>
        [EnumMember(Value = "AZURE")]
        AZURE,

        /// <summary>
        /// GENERICS3
        /// </summary>
        [EnumMember(Value = "GENERIC_S3")]
        GENERICS3,

        /// <summary>
        /// GCS
        /// </summary>
        [EnumMember(Value = "GCS")]
        GCS,

        /// <summary>
        /// FTP
        /// </summary>
        [EnumMember(Value = "FTP")]
        FTP,

        /// <summary>
        /// LOCAL
        /// </summary>
        [EnumMember(Value = "LOCAL")]
        LOCAL,

        /// <summary>
        /// S3
        /// </summary>
        [EnumMember(Value = "S3")]
        S3,

        /// <summary>
        /// S3ROLEBASED
        /// </summary>
        [EnumMember(Value = "S3_ROLE_BASED")]
        S3ROLEBASED,

        /// <summary>
        /// SFTP
        /// </summary>
        [EnumMember(Value = "SFTP")]
        SFTP,

        /// <summary>
        /// AKAMAIMSL
        /// </summary>
        [EnumMember(Value = "AKAMAI_MSL")]
        AKAMAIMSL,

        /// <summary>
        /// LIVEMEDIAINGEST
        /// </summary>
        [EnumMember(Value = "LIVE_MEDIA_INGEST")]
        LIVEMEDIAINGEST
    }
}
