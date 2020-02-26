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
    /// AutoRestartConfiguration
    /// </summary>
    public class AutoRestartConfiguration
    {
        /// <summary>
        /// If no segments were generated for the given number of seconds, a restart is triggered. Minimum: 30.0
        /// </summary>
        [JsonProperty(PropertyName = "segmentsWrittenTimeout")]
        public double? SegmentsWrittenTimeout { get; set; }

        /// <summary>
        /// If no data was written for the given number of seconds, a restart is triggered. Minimum: 30.0
        /// </summary>
        [JsonProperty(PropertyName = "bytesWrittenTimeout")]
        public double? BytesWrittenTimeout { get; set; }

        /// <summary>
        /// If no frames were generated for the given number of seconds, a restart is triggered. Minimum: 30.0
        /// </summary>
        [JsonProperty(PropertyName = "framesWrittenTimeout")]
        public double? FramesWrittenTimeout { get; set; }

        /// <summary>
        /// If HLS manifests were not updated for the given number of seconds, a restart is triggered. Minimum: 30.0
        /// </summary>
        [JsonProperty(PropertyName = "hlsManifestsUpdateTimeout")]
        public double? HlsManifestsUpdateTimeout { get; set; }

        /// <summary>
        /// If DASH manifests were not updated for the given number of seconds, a restart is triggered. Minimum: 30.0
        /// </summary>
        [JsonProperty(PropertyName = "dashManifestsUpdateTimeout")]
        public double? DashManifestsUpdateTimeout { get; set; }

        /// <summary>
        /// Defines a schedule for restarts using the unix crontab syntax. This example would trigger a restart every monday at 05:30 (AM)
        /// </summary>
        [JsonProperty(PropertyName = "scheduleExpression")]
        public string ScheduleExpression { get; set; }
    }
}
