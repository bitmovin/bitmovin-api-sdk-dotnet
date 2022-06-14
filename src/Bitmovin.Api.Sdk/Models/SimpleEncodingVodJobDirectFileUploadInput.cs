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
    /// SimpleEncodingVodJobDirectFileUploadInput
    /// </summary>
    public class SimpleEncodingVodJobDirectFileUploadInput : SimpleEncodingVodJobInput
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "DIRECT_FILE_UPLOAD";

        /// <summary>
        /// Id of a DirectFileUploadInput (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }

        /// <summary>
        /// Defines the type of the input file, if no type is set it is assumed that the input file contains at least one video stream and optionally one or multiple audio streams.  Note that when defining video and audio inputs, you can either - add one single input without inputType, in which case that source file must contain a video stream and (if you want audio) one audio stream, or - add one single input with inputType&#x3D;VIDEO and (if you want audio) one or more inputs with inputType&#x3D;AUDIO (each containing one audio stream)  Other combinations are not valid. 
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
