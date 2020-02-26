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
    /// StreamFilterList
    /// </summary>
    public class StreamFilterList
    {
        /// <summary>
        /// List of stream filters (required)
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public List<StreamFilter> Filters { get; set; } = new List<StreamFilter>();
    }
}
