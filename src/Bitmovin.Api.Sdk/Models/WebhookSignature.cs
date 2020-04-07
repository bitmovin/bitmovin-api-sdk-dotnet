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
    /// WebhookSignature
    /// </summary>
    public class WebhookSignature
    {
        /// <summary>
        /// The signature type used for the webhook.  Selects one of the supported signatures. The signature is attached to the list of headers with the key &#x60;Bitmovin-Signature&#x60;. In case of the &#x60;HMAC&#x60; type the SHA512 hashing algorithm is used to generate an authentication code from the webhook body. (required)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SignatureType? Type { get; set; }

        /// <summary>
        /// The key of the signature (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
}
