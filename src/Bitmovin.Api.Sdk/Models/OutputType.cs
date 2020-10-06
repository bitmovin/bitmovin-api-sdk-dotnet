using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// OutputType
    /// </summary>
    public enum OutputType
    {
        /// <summary>
        /// AKAMAI_NETSTORAGE
        /// </summary>
        [EnumMember(Value = "AKAMAI_NETSTORAGE")]
        AKAMAI_NETSTORAGE,

        /// <summary>
        /// AZURE
        /// </summary>
        [EnumMember(Value = "AZURE")]
        AZURE,

        /// <summary>
        /// GENERIC_S3
        /// </summary>
        [EnumMember(Value = "GENERIC_S3")]
        GENERIC_S3,

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
        /// S3_ROLE_BASED
        /// </summary>
        [EnumMember(Value = "S3_ROLE_BASED")]
        S3_ROLE_BASED,

        /// <summary>
        /// SFTP
        /// </summary>
        [EnumMember(Value = "SFTP")]
        SFTP,

        /// <summary>
        /// AKAMAI_MSL
        /// </summary>
        [EnumMember(Value = "AKAMAI_MSL")]
        AKAMAI_MSL,

        /// <summary>
        /// LIVE_MEDIA_INGEST
        /// </summary>
        [EnumMember(Value = "LIVE_MEDIA_INGEST")]
        LIVE_MEDIA_INGEST,

        /// <summary>
        /// GCS_SERVICE_ACCOUNT
        /// </summary>
        [EnumMember(Value = "GCS_SERVICE_ACCOUNT")]
        GCS_SERVICE_ACCOUNT
    }
}
