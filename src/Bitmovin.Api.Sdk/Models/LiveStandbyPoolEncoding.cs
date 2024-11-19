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
    /// LiveStandbyPoolEncoding
    /// </summary>
    public class LiveStandbyPoolEncoding
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public string CreatedAt { get; internal set; }

        /// <summary>
        /// ModifiedAt
        /// </summary>
        [JsonProperty(PropertyName = "modifiedAt")]
        public string ModifiedAt { get; internal set; }

        /// <summary>
        /// ID of the encoding that ready for ingest in the standby pool
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; internal set; }

        /// <summary>
        /// Manifests
        /// </summary>
        [JsonProperty(PropertyName = "manifests")]
        public List<LiveStandbyPoolEncodingManifest> Manifests { get; set; } = new List<LiveStandbyPoolEncodingManifest>();

        /// <summary>
        /// IngestPoints
        /// </summary>
        [JsonProperty(PropertyName = "ingestPoints")]
        public List<LiveStandbyPoolEncodingIngestPoint> IngestPoints { get; set; } = new List<LiveStandbyPoolEncodingIngestPoint>();

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public LiveStandbyPoolEncodingStatus? Status { get; set; }
    }
}
