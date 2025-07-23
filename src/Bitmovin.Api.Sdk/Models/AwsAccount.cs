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
        /// Deprecated: Amazon access key for legacy support. Use &#x60;roleName&#x60; instead
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Deprecated: Amazon secret key for legacy support. Use &#x60;roleName&#x60; instead
        /// </summary>
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }

        /// <summary>
        /// Amazon account number (12 digits as per AWS spec) (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Role name including path for the AWS IAM role that will be used by Bitmovin to access the AWS account depicted by &#x60;accountNumber&#x60;. The role ARN is constructed based on &#x60;accountNumber&#x60; and &#x60;roleName&#x60;: &#x60;arn:aws:iam::{accountNumber}:role/{roleName}&#x60;.  For details on how to create the AWS IAM role in your account, please refer to the [AWS cloud connect setup guide](https://developer.bitmovin.com/encoding/docs/using-bitmovin-cloud-connect-with-aws). 
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// External ID that needs to be set in the trust policy of the AWS IAM role (depicted by &#x60;roleName&#x60;) that allows Bitmovin access to the AWS account depicted by &#x60;accountNumber&#x60;
        /// </summary>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; internal set; }
    }
}
