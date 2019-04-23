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
    /// WebVttSidecarFile
    /// </summary>

    public class WebVttSidecarFile : SidecarFile
    {
        /// <summary>
        /// Segmentation
        /// </summary>
        [JsonProperty(PropertyName = "segmentation")]
        public WebVttSidecarFileSegmentation Segmentation { get; set; }
    }

}
