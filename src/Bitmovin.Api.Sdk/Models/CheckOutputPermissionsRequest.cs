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
    /// CheckOutputPermissionsRequest
    /// </summary>
    public class CheckOutputPermissionsRequest
    {
        /// <summary>
        /// The path on the storage for which permissions should be checked. In AWS S3 terminology, this corresponds to a \&quot;prefix\&quot;. To perform the check, an empty test file (WritePermissionTestFile.txt) will be created in this location. Defaults to an empty string, which corresponds to the root directory.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
    }
}
