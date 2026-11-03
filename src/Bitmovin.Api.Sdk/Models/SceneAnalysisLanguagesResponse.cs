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
    /// Available language variants of an analysis result.
    /// </summary>
    public class SceneAnalysisLanguagesResponse
    {
        /// <summary>
        /// Language codes registered for available analysis details. The base English result can be included even when no translations were requested; this is not the list of detected input languages.
        /// </summary>
        [JsonProperty(PropertyName = "outputLanguageCodes")]
        public List<string> OutputLanguageCodes { get; set; } = new List<string>();
    }
}
