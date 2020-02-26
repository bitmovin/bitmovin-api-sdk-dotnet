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
    /// AwsAccount
    /// </summary>
    public class AwsAccount : BitmovinResource
    {
        /// <summary>
        /// Amazon access key (required)
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Amazon secret key (required)
        /// </summary>
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }

        /// <summary>
        /// Amazon account number (12 digits as per AWS spec) (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }
    }
}
