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
    /// An external WebVTT file that is added to an encoding. The size limit for a sidecar file is 10 MB
    /// </summary>
    public class WebVttSidecarFile : SidecarFile
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "WEB_VTT";

        /// <summary>
        /// Segmentation
        /// </summary>
        [JsonProperty(PropertyName = "segmentation")]
        public WebVttSidecarFileSegmentation Segmentation { get; set; }
    }
}
