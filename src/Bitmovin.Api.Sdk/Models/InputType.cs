using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// InputType
    /// </summary>
    public enum InputType
    {
        /// <summary>
        /// AKAMAI_NETSTORAGE
        /// </summary>
        [EnumMember(Value = "AKAMAI_NETSTORAGE")]
        AKAMAI_NETSTORAGE,

        /// <summary>
        /// ASPERA
        /// </summary>
        [EnumMember(Value = "ASPERA")]
        ASPERA,

        /// <summary>
        /// AZURE
        /// </summary>
        [EnumMember(Value = "AZURE")]
        AZURE,

        /// <summary>
        /// REDUNDANT_RTMP
        /// </summary>
        [EnumMember(Value = "REDUNDANT_RTMP")]
        REDUNDANT_RTMP,

        /// <summary>
        /// FTP
        /// </summary>
        [EnumMember(Value = "FTP")]
        FTP,

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
        /// HTTP
        /// </summary>
        [EnumMember(Value = "HTTP")]
        HTTP,

        /// <summary>
        /// HTTPS
        /// </summary>
        [EnumMember(Value = "HTTPS")]
        HTTPS,

        /// <summary>
        /// LOCAL
        /// </summary>
        [EnumMember(Value = "LOCAL")]
        LOCAL,

        /// <summary>
        /// RTMP
        /// </summary>
        [EnumMember(Value = "RTMP")]
        RTMP,

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
        /// TCP
        /// </summary>
        [EnumMember(Value = "TCP")]
        TCP,

        /// <summary>
        /// UDP
        /// </summary>
        [EnumMember(Value = "UDP")]
        UDP,

        /// <summary>
        /// UDP_MULTICAST
        /// </summary>
        [EnumMember(Value = "UDP_MULTICAST")]
        UDP_MULTICAST,

        /// <summary>
        /// ZIXI
        /// </summary>
        [EnumMember(Value = "ZIXI")]
        ZIXI,

        /// <summary>
        /// SRT
        /// </summary>
        [EnumMember(Value = "SRT")]
        SRT,

        /// <summary>
        /// GCS_SERVICE_ACCOUNT
        /// </summary>
        [EnumMember(Value = "GCS_SERVICE_ACCOUNT")]
        GCS_SERVICE_ACCOUNT
    }
}
