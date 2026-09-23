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
    /// AiSceneAnalysisLiveOutput
    /// </summary>
    public class AiSceneAnalysisLiveOutput
    {
        /// <summary>
        /// ID of an existing Encoding Output owned by the organization. Set either this property or &#x60;output&#x60;, but not both.
        /// </summary>
        [JsonProperty(PropertyName = "outputId")]
        public string OutputId { get; set; }

        /// <summary>
        /// Inline definition of a concrete, publicly creatable Encoding Output to create synchronously. Only properties defined by the selected concrete Output type are accepted; internal types and properties are not supported. Deprecated properties that remain supported by the Encoding Output creation API are accepted. Set either this property or &#x60;outputId&#x60;, but not both. Put ACL entries on the destination-level &#x60;acl&#x60; property, not in this resource definition. The created Output is an ordinary reusable Encoding resource and is not automatically deleted with the Live Analysis or after provisioning failure.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public Output Output { get; set; }

        /// <summary>
        /// Subdirectory where files are written. This destination setting is not part of the inline Output resource definition. (required)
        /// </summary>
        [JsonProperty(PropertyName = "outputPath")]
        public string OutputPath { get; set; }

        /// <summary>
        /// Determines accessibility of files written to this destination. Only applies to Output types that support ACLs. Defaults to PUBLIC_READ if the list is empty.
        /// </summary>
        [JsonProperty(PropertyName = "acl")]
        public List<AclEntry> Acl { get; set; } = new List<AclEntry>();
    }
}
