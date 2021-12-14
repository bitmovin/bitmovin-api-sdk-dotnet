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
    /// VideoAdaptationSet
    /// </summary>
    public class VideoAdaptationSet : AdaptationSet
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "VIDEO";

    }
}
