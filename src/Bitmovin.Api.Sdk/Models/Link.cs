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
    /// Link
    /// </summary>

    public class Link
    {
        /// <summary>
        /// webpage target URL
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }
        
        /// <summary>
        /// Short description of the linked page
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }

}
