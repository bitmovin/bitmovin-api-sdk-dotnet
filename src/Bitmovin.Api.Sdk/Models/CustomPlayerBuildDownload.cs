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
    /// Custom player download information
    /// </summary>
    public class CustomPlayerBuildDownload
    {
        /// <summary>
        /// The link to download the custom built player (required)
        /// </summary>
        [JsonProperty(PropertyName = "downloadLink")]
        public string DownloadLink { get; set; }

        /// <summary>
        /// Until this date the download link is valid and can be downloaded. (required)
        /// </summary>
        [JsonProperty(PropertyName = "expiresAt")]
        public DateTime? ExpiresAt { get; set; }
    }
}
