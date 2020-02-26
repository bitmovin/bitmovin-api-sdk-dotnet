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
    /// DefaultManifestCondition
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(DefaultManifestAttributeCondition), "CONDITION")]
    [JsonSubtypes.KnownSubType(typeof(DefaultManifestAndCondition), "AND")]
    [JsonSubtypes.KnownSubType(typeof(DefaultManifestOrCondition), "OR")]

    public class DefaultManifestCondition
    {
    }
}
