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
    /// SimpleEncodingVodJobUrlInput
    /// </summary>
    public class SimpleEncodingVodJobUrlInput
    {
        /// <summary>
        /// Define a URL pointing to the asset that should be encoded. The URL has to point to a file.  Currently the following protocols/storages systems are supported: HTTP(S), (S)FTP, S3, GCS, Azure Blob Storage, Akamai NetStorage. Note that most protocols will require &#x60;credentials&#x60; to access the asset. Check the description below which ones are applicable. See below how to construct the URLs for the individual protocals/storage systems.  - --  **HTTP** and **HTTPS**: * &#x60;http://&lt;host&gt;[:&lt;port&gt;]/path/file.mp4&#x60; * &#x60;https://&lt;host&gt;[:&lt;port&gt;]/path/file.mp4&#x60;  The port is defaulted to 80 if it&#39;s not provided. If the content is secured by Basic Authentication please provide corresponding credentials.  **FTP** and **SFTP**: * &#x60;ftp://&lt;host&gt;[:&lt;port&gt;]/path/file.mp4&#x60; * &#x60;sftp://&lt;host&gt;[:&lt;port&gt;]/path/file.mp4&#x60;  The port is defaulted to 21 (ftp) or  22 (sftp) if it&#39;s not provided. If the content is secured please provide corresponding credentials.  **S3**: * &#x60;s3://&lt;my-bucket&gt;/path/file.mp4&#x60;  Authentication can be done via accesskey/secretkey or role-based authentication. Generic S3 is currently NOT supported.  **GCS**: * &#x60;gcs://&lt;my-bucket&gt;/path/file.mp4&#x60;  Authentication can be done via accesskey/secretkey or a service account  **Azure Blob Storage (ABS)**: * &#x60;https://&lt;account&gt;.blob.core.windows.net/&lt;container&gt;/path/file.mp4&#x60;  It is required to provide the Azure key credentials for authentication.  **Akamai NetStorage**: * &#x60;https://&lt;host&gt;-nsu.akamaihd.net/&lt;CP-code&gt;/path/file.mp4&#x60;  It is required to provider username/password credentials for authentication. (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Credentials to be used for authentication and accessing the file. Check out the examples on how to define the credentials correctly. 
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public SimpleEncodingVodJobCredentials Credentials { get; set; }

        /// <summary>
        /// Defines the type of the input file, if no type is set it is assumed that the input file contains at least one video stream and optionally one or multiple audio streams. 
        /// </summary>
        [JsonProperty(PropertyName = "inputType")]
        public SimpleEncodingVodJobInputType? InputType { get; set; }

        /// <summary>
        /// The language of the audio track, the subtitles, or closed captions file. The language code  must be compliant with [BCP 47](https://datatracker.ietf.org/doc/html/rfc5646).  This property is mandatory if the input provided is of type SUBTITLES or CLOSED_CAPTIONS and  recommended for input type AUDIO and an input that does not specify an input type (combined  audio and video). If an audio input does not specify the language, it is defaulted to &#x60;und&#x60;  (undefined). 
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
    }
}
