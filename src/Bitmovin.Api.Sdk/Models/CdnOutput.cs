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
    /// CdnOutput
    /// </summary>
    public class CdnOutput : Output
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "CDN";

        /// <summary>
        /// Domain name for public access to CDN content
        /// </summary>
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; internal set; }
    }
}
