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
    /// AzureSpeechToCaptionsSettings
    /// </summary>
    public class AzureSpeechToCaptionsSettings
    {
        /// <summary>
        /// Credential settings to access Azure Speech Services 
        /// </summary>
        [JsonProperty(PropertyName = "azureSpeechServicesCredentials")]
        public AzureSpeechServicesCredentials AzureSpeechServicesCredentials { get; set; }

        /// <summary>
        /// Azure Speech Services Region Identifier. The list of speech service supported regions can be found at Azure&#39;s official documentation. 
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Azure Speech Services API endpoint. This information can be found in Azure&#39;s Speech resource data. 
        /// </summary>
        [JsonProperty(PropertyName = "apiEndpoint")]
        public string ApiEndpoint { get; set; }

        /// <summary>
        /// Azure Speech to captions supported language (IETF BCP 47 language tag). The list of supported languages can be found at Azure&#39;s official documentation. 
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// How many MILLISECONDS to delay the display of each caption, to mimic a real-time experience. The minimum value is 0. 
        /// </summary>
        [JsonProperty(PropertyName = "captionDelay")]
        public long? CaptionDelay { get; set; }

        /// <summary>
        /// How many MILLISECONDS a caption should remain on screen if it is not replaced by another. The minimum value is 0. 
        /// </summary>
        [JsonProperty(PropertyName = "captionRemainTime")]
        public long? CaptionRemainTime { get; set; }

        /// <summary>
        /// The maximum number of characters per line for a caption.  The minimum value is 20. 
        /// </summary>
        [JsonProperty(PropertyName = "captionMaxLineLength")]
        public long? CaptionMaxLineLength { get; set; }

        /// <summary>
        /// The number of lines for a caption. The minimum value is 1. 
        /// </summary>
        [JsonProperty(PropertyName = "captionLines")]
        public long? CaptionLines { get; set; }

        /// <summary>
        /// The profanity filter options are:  - Masked: Replaces letters in profane words with asterisk (*) characters. - Raw: Include the profane words verbatim. - Removed: Removes profane words. 
        /// </summary>
        [JsonProperty(PropertyName = "profanityOption")]
        public AzureSpeechToCaptionsProfanity? ProfanityOption { get; set; }
    }
}
