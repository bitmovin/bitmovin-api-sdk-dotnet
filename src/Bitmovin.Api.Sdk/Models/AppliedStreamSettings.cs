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
    /// AppliedStreamSettings
    /// </summary>

    public class AppliedStreamSettings
    {
        /// <summary>
        /// The applied width. Useful if the width in the configuration was undefined
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }
        
        /// <summary>
        /// The applied height. Useful if the height in the configuration was undefined
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }
    }

}
