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
    /// Output
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(AkamaiNetStorageOutput), "AKAMAI_NETSTORAGE")]
    [JsonSubtypes.KnownSubType(typeof(AzureOutput), "AZURE")]
    [JsonSubtypes.KnownSubType(typeof(GenericS3Output), "GENERIC_S3")]
    [JsonSubtypes.KnownSubType(typeof(GcsOutput), "GCS")]
    [JsonSubtypes.KnownSubType(typeof(FtpOutput), "FTP")]
    [JsonSubtypes.KnownSubType(typeof(LocalOutput), "LOCAL")]
    [JsonSubtypes.KnownSubType(typeof(S3Output), "S3")]
    [JsonSubtypes.KnownSubType(typeof(S3RoleBasedOutput), "S3_ROLE_BASED")]
    [JsonSubtypes.KnownSubType(typeof(SftpOutput), "SFTP")]
    [JsonSubtypes.KnownSubType(typeof(AkamaiMslOutput), "AKAMAI_MSL")]
    [JsonSubtypes.KnownSubType(typeof(LiveMediaIngestOutput), "LIVE_MEDIA_INGEST")]

    public class Output : BitmovinResource
    {
        /// <summary>
        /// Acl
        /// </summary>
        [JsonProperty(PropertyName = "acl")]
        public List<AclEntry> Acl { get; set; } = new List<AclEntry>();
    }

}
