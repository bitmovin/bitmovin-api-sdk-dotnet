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
    /// DashChunkedTextRepresentation
    /// </summary>
    public class DashChunkedTextRepresentation : DashSegmentedRepresentation
    {
        [JsonProperty(PropertyName = "typeDiscriminator")]
        private readonly string _typeDiscriminator = "CHUNKED_TEXT";

    }
}
