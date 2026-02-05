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
#pragma warning disable CS0414
        private readonly string _type = "DIRECT_FILE_UPLOAD";
#pragma warning restore CS0414

        /// <summary>
        /// The URL to be used for a file upload with HTTP PUT. Expires after 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "uploadUrl")]
        public string UploadUrl { get; internal set; }
    }
}
