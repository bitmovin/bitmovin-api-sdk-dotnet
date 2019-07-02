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
    /// ProgressiveTsMuxingInformation
    /// </summary>

    public class ProgressiveTsMuxingInformation : ProgressiveMuxingInformation
    {
        /// <summary>
        /// Byte ranges for the segments within the TS file
        /// </summary>
        [JsonProperty(PropertyName = "byteRanges")]
        public List<ProgressiveTsMuxingInformationByteRanges> ByteRanges { get; internal set; } = new List<ProgressiveTsMuxingInformationByteRanges>();
    }

}
