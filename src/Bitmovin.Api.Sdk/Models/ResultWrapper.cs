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
    /// ResultWrapper
    /// </summary>
    public class ResultWrapper<T>
    {
        /// <summary>
        /// Result
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public T Result { get; internal set; }
    }
}
