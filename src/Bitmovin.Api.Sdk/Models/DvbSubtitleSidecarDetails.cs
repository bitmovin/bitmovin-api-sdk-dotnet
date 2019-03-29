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
    /// DvbSubtitleSidecarDetails
    /// </summary>

    public class DvbSubtitleSidecarDetails : BitmovinResource
    {
        /// <summary>
        /// The input stream to extract the subtitle from
        /// </summary>
        [JsonProperty(PropertyName = "inputStream")]
        public InputStream InputStream { get; set; }
        
        /// <summary>
        /// The output where the extracted subtitle should be written to
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<Output> Outputs { get; set; }
        
        /// <summary>
        /// Naming strategy for the image files
        /// </summary>
        [JsonProperty(PropertyName = "imageFileNaming")]
        public string ImageFileNaming { get; set; }
        
        /// <summary>
        /// Name of the index file
        /// </summary>
        [JsonProperty(PropertyName = "indexFilename")]
        public string IndexFilename { get; set; }
        
        /// <summary>
        /// Specify the format of the generated images
        /// </summary>
        [JsonProperty(PropertyName = "imageFormat")]
        public string ImageFormat { get; set; }
        
        /// <summary>
        /// OutputFormat
        /// </summary>
        [JsonProperty(PropertyName = "outputFormat")]
        public string OutputFormat { get; set; }
    }

}
