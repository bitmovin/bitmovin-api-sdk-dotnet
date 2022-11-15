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
    /// SimpleEncodingVodJobOutputArtifact
    /// </summary>
    public class SimpleEncodingVodJobOutputArtifact
    {
        /// <summary>
        /// Name of the artifact. Currently we provide the URL of the HLS manifest with name &#39;HLS_MANIFEST_URL&#39; and the URL of the DASH manifest with name &#39;DASH_MANIFEST_URL&#39; 
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; internal set; }

        /// <summary>
        /// A string value described by the &#39;name&#39; property. Typically this is an absolute URL pointing to a file on the output you specified for the encoding job. The protocol depends on the type of output: \&quot;s3://\&quot; for AWS S3,\&quot;gcs://\&quot; for Google Cloud Storage, \&quot;https://\&quot; for Azure Blob Storage and Akamai NetStorage ) 
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; internal set; }
    }
}
