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
    /// Live Media and Metadata Ingest Protocol. See https://tools.ietf.org/html/draft-mekuria-mmediaingest-01.
    /// </summary>
    public class LiveMediaIngestOutput : Output
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "LIVE_MEDIA_INGEST";

        /// <summary>
        /// URL specifying the publishing point for the output. Can use either http or https. (required)
        /// </summary>
        [JsonProperty(PropertyName = "publishingPoint")]
        public string PublishingPoint { get; set; }
    }
}
