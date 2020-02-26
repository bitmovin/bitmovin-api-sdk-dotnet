using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Input
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(AkamaiNetStorageInput), "AKAMAI_NETSTORAGE")]
    [JsonSubtypes.KnownSubType(typeof(AsperaInput), "ASPERA")]
    [JsonSubtypes.KnownSubType(typeof(AzureInput), "AZURE")]
    [JsonSubtypes.KnownSubType(typeof(RedundantRtmpInput), "REDUNDANT_RTMP")]
    [JsonSubtypes.KnownSubType(typeof(FtpInput), "FTP")]
    [JsonSubtypes.KnownSubType(typeof(GenericS3Input), "GENERIC_S3")]
    [JsonSubtypes.KnownSubType(typeof(GcsInput), "GCS")]
    [JsonSubtypes.KnownSubType(typeof(HttpInput), "HTTP")]
    [JsonSubtypes.KnownSubType(typeof(HttpsInput), "HTTPS")]
    [JsonSubtypes.KnownSubType(typeof(LocalInput), "LOCAL")]
    [JsonSubtypes.KnownSubType(typeof(RtmpInput), "RTMP")]
    [JsonSubtypes.KnownSubType(typeof(S3Input), "S3")]
    [JsonSubtypes.KnownSubType(typeof(S3RoleBasedInput), "S3_ROLE_BASED")]
    [JsonSubtypes.KnownSubType(typeof(SftpInput), "SFTP")]
    [JsonSubtypes.KnownSubType(typeof(TcpInput), "TCP")]
    [JsonSubtypes.KnownSubType(typeof(UdpInput), "UDP")]
    [JsonSubtypes.KnownSubType(typeof(UdpMulticastInput), "UDP_MULTICAST")]
    [JsonSubtypes.KnownSubType(typeof(ZixiInput), "ZIXI")]
    [JsonSubtypes.KnownSubType(typeof(SrtInput), "SRT")]

    public class Input : BitmovinResource
    {
    }
}
