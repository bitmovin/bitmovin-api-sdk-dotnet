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
    /// WebhookEncryption
    /// </summary>
    public class WebhookEncryption
    {
        /// <summary>
        /// The encryption algorithm used for the webhook (required)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public EncryptionType? Type { get; set; }

        /// <summary>
        /// The key of the encryption (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
}
