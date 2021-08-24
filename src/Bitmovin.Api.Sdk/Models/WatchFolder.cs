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
    /// WatchFolder
    /// </summary>
    public class WatchFolder : BitmovinResource
    {
        /// <summary>
        /// Input
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public WatchFolderInput Input { get; set; }

        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<WatchFolderOutput> Outputs { get; set; } = new List<WatchFolderOutput>();

        /// <summary>
        /// The current status of the Watch Folder. The default value is &#x60;STOPPED&#x60; (required)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public WatchFolderStatus? Status { get; internal set; }

        /// <summary>
        /// A description text of the current status (required)
        /// </summary>
        [JsonProperty(PropertyName = "statusText")]
        public string StatusText { get; internal set; }
    }
}
