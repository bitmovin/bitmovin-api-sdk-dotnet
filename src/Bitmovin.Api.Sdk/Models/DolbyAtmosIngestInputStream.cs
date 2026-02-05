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
    /// DolbyAtmosIngestInputStream
    /// </summary>
    public class DolbyAtmosIngestInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "DOLBY_ATMOS";
#pragma warning restore CS0414

        /// <summary>
        /// Id of input (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Path to the Dolby Atmos input file (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; set; }

        /// <summary>
        /// Input file format of the Dolby Atmos input file.  Set it to DAMF if the given input file is a Dolby Atmos Master File (.atmos). Set it to ADM if the given input file is an Audio Definition Model Broadcast Wave Format file (.wav) (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputFormat")]
        public DolbyAtmosInputFormat? InputFormat { get; set; }
    }
}
