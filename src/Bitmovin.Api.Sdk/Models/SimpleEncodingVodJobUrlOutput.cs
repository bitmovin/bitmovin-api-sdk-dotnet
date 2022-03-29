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
    /// SimpleEncodingVodJobUrlOutput
    /// </summary>
    public class SimpleEncodingVodJobUrlOutput : SimpleEncodingVodJobOutput
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "URL";

        /// <summary>
        /// Define a URL pointing to a folder which will be used to upload the encoded assets.  The output folder structure used looks the following way: &lt;br&gt;&lt;br&gt; &#x60;http://host/my-folder&#x60;     &lt;ul&gt;       &lt;li&gt;         &#x60;/video&#x60;         &lt;ul&gt;           &lt;li&gt;&#x60;/h264/{width}x{height}_{bitrate}/&#x60; (multiple subfolders containing different output renditions)&lt;/li&gt;         &lt;/ul&gt;       &lt;/li&gt;       &lt;li&gt;&#x60;/audio&#x60;         &lt;ul&gt;           &lt;li&gt;&#x60;/aac/{language}/&#x60; - if language is unique (subfolder containing audio output files)&lt;/li&gt;           &lt;li&gt;&#x60;/aac/{language}_{index}/&#x60; - if language is not unique (subfolder containing audio output files)&lt;/li&gt;         &lt;/ul&gt;       &lt;/li&gt;       &lt;li&gt;&#x60;/subtitles&#x60; (subfolder containing subtitles files)&lt;/li&gt;       &lt;li&gt;&#x60;/captions&#x60; (subfolder containing subtitles files)&lt;/li&gt;       &lt;li&gt;&#x60;/sprites&#x60; (subfolder containing generated sprites)&lt;/li&gt;       &lt;li&gt;&#x60;/thumbnails&#x60; (subfolder containing generated thumbnails)&lt;/li&gt;       &lt;li&gt;&#x60;/index.m3u8&#x60; (HLS manifest file) &lt;/li&gt;       &lt;li&gt;&#x60;/stream.mpd&#x60; (DASH manifest file) &lt;/li&gt;     &lt;/ul&gt;    Currently the following protocols/storages systems are supported: S3, GCS, Azure Blob Storage, Akamai NetStorage. Note that most protocols will require &#x60;credentials&#x60; to access the asset. Check in the descriptions below which properties can or need to be provided within the &#x60;credentials&#x60; key. See below how to construct the URLs for the individual protocols/storage systems. ___ **Recommendation** To ensure uniqueness of output paths accross multiple encodings, make use of the following placeholders in the output&#39;s URL: {uuid} - will be replaced with a random UUID {asset} - will be replaced with the asset file name (only for the input type VIDEO or DEFAULT)  Examples:  * using the &#x60;{uuid}&#x60; placeholder: The output URL &#x60;s3://&lt;my-bucket&gt;/{uuid}/path/&#x60; will be transformed to e.g. &#x60;s3://&lt;my-bucket&gt;/d59295f3-1548-4bd9-843d-6ac6896dbdb6/path/&#x60;.  * using the &#x60;{asset}&#x60; placeholder: Given an input &#x60;s3://my-bucket/path/filename.mp4&#x60; of type VIDEO or DEFAULT, the output URL  &#x60;s3://&lt;my-bucket&gt;/{asset}/path/&#x60; will be transformed to &#x60;s3://&lt;my-bucket&gt;/filename/path/&#x60;  Note: the placeholders can be combined or used multiple times in the same URL. ___  **S3**: * &#x60;s3://&lt;my-bucket&gt;/path/&#x60;  Authentication can be done via accesskey/secretkey or role-based authentication. Generic S3 is currently NOT supported.  **GCS**: * &#x60;gcs://&lt;my-bucket&gt;/path/&#x60;  Authentication can be done via accesskey/secretkey or a service account  **Azure Blob Storage (ABS)**: * &#x60;https://&lt;account&gt;.blob.core.windows.net/&lt;container&gt;/path/&#x60;  It is required to provide the Azure key credentials for authentication.  **Akamai NetStorage**: * &#x60;https://&lt;host&gt;-nsu.akamaihd.net/&lt;CP-code&gt;/path/&#x60;  It is required to provide username/password credentials for authentication. (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Credentials to be used for authentication and accessing the folder 
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public SimpleEncodingVodJobCredentials Credentials { get; set; }

        /// <summary>
        /// Indicates if the output should be publically available so that playback immediately works over the internet. Note that not every storage provider supports public output, in this case the flag will be ignored (e.g., Akamai NetStorage).  It might forbidden by some storage configuration to make files public, for example an S3 buckets can be configured to disallow public access. In this case set it to false. 
        /// </summary>
        [JsonProperty(PropertyName = "makePublic")]
        public bool? MakePublic { get; set; }
    }
}
