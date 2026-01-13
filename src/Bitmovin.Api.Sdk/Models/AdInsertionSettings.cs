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
    /// AdInsertionSettings
    /// </summary>
    public class AdInsertionSettings
    {
        /// <summary>
        /// Enabling this allows on-demand insertion of ESAM MediaPoints. When enabled, the encoder ensures that at least one SCTE-35 data stream is available.
        /// </summary>
        [JsonProperty(PropertyName = "enableEsamMediaPointInsertion")]
        public bool? EnableEsamMediaPointInsertion { get; set; }

        /// <summary>
        /// Mode of clock synchronization during ad insertion.  If an HLS manifest is configured that has a PDT source set, the encoder defaults to the equivalent clockSynchronizationMode.  If both, HLS PDT source and clockSynchronizationMode, are set and don&#39;t match, the encoding will fail. 
        /// </summary>
        [JsonProperty(PropertyName = "clockSynchronizationMode")]
        public ClockSynchronizationMode? ClockSynchronizationMode { get; set; }
    }
}
