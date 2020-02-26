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
    /// PlayReadyAdditionalInformation
    /// </summary>
    public class PlayReadyAdditionalInformation
    {
        /// <summary>
        /// Custom attributes that you want to add to the WRM header. This string must be valid xml. Some DRM providers require some information in the custom attributes of the msr:pro tag of the DASH manifest, otherwise the content does not play on certain devices.
        /// </summary>
        [JsonProperty(PropertyName = "wrmHeaderCustomAttributes")]
        public string WrmHeaderCustomAttributes { get; set; }
    }
}
