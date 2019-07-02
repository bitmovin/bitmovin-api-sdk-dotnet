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
    /// AbstractConjunction
    /// </summary>

    public class AbstractConjunction : AbstractCondition
    {
        /// <summary>
        /// Array to perform the AND/OR evaluation on
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public List<AbstractCondition> Conditions { get; set; } = new List<AbstractCondition>();
    }

}
