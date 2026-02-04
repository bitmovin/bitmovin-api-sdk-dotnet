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
    /// LiveStandbyPoolAcquireEncoding
    /// </summary>
    public class LiveStandbyPoolAcquireEncoding
    {
        /// <summary>
        /// Note: This is not implemented yet and will be ignored if provided. List of ingest points to be used for the acquired encoding. The DNS hostname and RTMPs application name and streamKey will be assigned to the encoding. 
        /// </summary>
        [JsonProperty(PropertyName = "ingestPoints")]
        public List<LiveStandbyPoolEncodingIngestPoint> IngestPoints { get; set; } = new List<LiveStandbyPoolEncodingIngestPoint>();
    }
}
