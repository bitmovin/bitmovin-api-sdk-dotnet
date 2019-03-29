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
    /// ReuploadSettings
    /// </summary>

    public class ReuploadSettings
    {
        /// <summary>
        /// Interval in seconds to reupload the DASH manifest (minimum value: 30)
        /// </summary>
        [JsonProperty(PropertyName = "dashManifestInterval")]
        public double? DashManifestInterval { get; set; }
        
        /// <summary>
        /// Interval in seconds to reupload the HLS master file. This is currently not used, as the master file will always be uploaded when one of the playlist files has changed (minimum value: 30)
        /// </summary>
        [JsonProperty(PropertyName = "hlsManifestInterval")]
        public double? HlsManifestInterval { get; set; }
        
        /// <summary>
        /// The interval in seconds to reupload the init file for segmented muxings (e.g. fMP4, WebM) (minimum value: 30)
        /// </summary>
        [JsonProperty(PropertyName = "muxingInitFileInterval")]
        public double? MuxingInitFileInterval { get; set; }
    }

}
