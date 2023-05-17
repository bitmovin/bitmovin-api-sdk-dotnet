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
    /// ProgramDateTimeSettings
    /// </summary>
    public class ProgramDateTimeSettings
    {
        /// <summary>
        /// ProgramDateTimeSource
        /// </summary>
        [JsonProperty(PropertyName = "programDateTimeSource")]
        public ProgramDateTimeSource? ProgramDateTimeSource { get; set; }
    }
}
