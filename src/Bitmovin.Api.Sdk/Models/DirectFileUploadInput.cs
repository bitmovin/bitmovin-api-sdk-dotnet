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
    /// DirectFileUploadInput
    /// </summary>
    public class DirectFileUploadInput : Input
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "DIRECT_FILE_UPLOAD";

        /// <summary>
        /// The URL to be used for a file upload with HTTP PUT. Expires after 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "uploadUrl")]
        public string UploadUrl { get; internal set; }
    }
}
