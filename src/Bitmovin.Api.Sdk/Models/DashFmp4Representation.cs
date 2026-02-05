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
    /// DashFmp4Representation
    /// </summary>
    public class DashFmp4Representation : DashSegmentedRepresentation
    {
        [JsonProperty(PropertyName = "typeDiscriminator")]
#pragma warning disable CS0414
        private readonly string _typeDiscriminator = "FMP4";
#pragma warning restore CS0414

    }
}
