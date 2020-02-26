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
    /// AbstractCondition
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(Condition), "CONDITION")]
    [JsonSubtypes.KnownSubType(typeof(AndConjunction), "AND")]
    [JsonSubtypes.KnownSubType(typeof(OrConjunction), "OR")]

    public class AbstractCondition
    {
    }
}
