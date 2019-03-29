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
    /// StreamConditionsMode
    /// </summary>
    public enum StreamConditionsMode
    {
        /// <summary>
        /// The whole muxing will be omitted if one or more of its stream conditions are not fulfilled
        /// </summary>
        [EnumMember(Value = "DROP_MUXING")]
        DROP_MUXING,
        
        /// <summary>
        /// Streams not fulfilling the stream conditions will be omitted from the muxing. The muxing will be omitted if there is no stream meeting the conditions.
        /// </summary>
        [EnumMember(Value = "DROP_STREAM")]
        DROP_STREAM
        
    }

}
