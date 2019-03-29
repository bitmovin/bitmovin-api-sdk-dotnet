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
    /// Condition
    /// </summary>

    public class Condition : AbstractCondition
    {
        /// <summary>
        /// Attribute
        /// </summary>
        [JsonProperty(PropertyName = "attribute")]
        public ConditionAttribute Attribute { get; set; }
        
        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public ConditionOperator Operator { get; set; }
        
        /// <summary>
        /// The value that should be used for comparison
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }

}
