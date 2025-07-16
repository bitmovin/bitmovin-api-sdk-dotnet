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
        /// Deprecated: Amazon access key for legacy support. Use roleName instead
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Deprecated: Amazon secret key for legacy support. Use roleName instead
        /// </summary>
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }

        /// <summary>
        /// Amazon account number (12 digits as per AWS spec) (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Role name including path for the AWS IAM role that will be used by Bitmovin to access the AWS account depicted by accountNumber. The role ARN is constructed based on accountNumber and roleName: arn:aws:iam::{accountNumber}:role/{roleName}
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// External ID that needs to be set in the trust policy of the AWS IAM role (depicted by roleName) that allows Bitmovin access to the AWS account depicted by accountNumber
        /// </summary>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; internal set; }
    }
}
