using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// InputType
    /// </summary>
    public enum InputType
    {
        /// <summary>
        /// AKAMAINETSTORAGE
        /// </summary>
        [EnumMember(Value = "AKAMAI_NETSTORAGE")]
        AKAMAINETSTORAGE,

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
        /// REDUNDANTRTMP
        /// </summary>
        [EnumMember(Value = "REDUNDANT_RTMP")]
        REDUNDANTRTMP,

        /// <summary>
        /// FTP
        /// </summary>
        [EnumMember(Value = "FTP")]
        FTP,

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
        /// UDPMULTICAST
        /// </summary>
        [EnumMember(Value = "UDP_MULTICAST")]
        UDPMULTICAST,

        /// <summary>
        /// ZIXI
        /// </summary>
        [EnumMember(Value = "ZIXI")]
        ZIXI,

        /// <summary>
        /// SRT
        /// </summary>
        [EnumMember(Value = "SRT")]
        SRT
    }
}
