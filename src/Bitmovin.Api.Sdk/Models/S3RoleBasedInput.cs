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
    /// S3RoleBasedInput
    /// </summary>

    public class S3RoleBasedInput : Input
    {
        /// <summary>
        /// Amazon S3 bucket name
        /// </summary>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <summary>
        /// Amazon ARN of the Role that will be assumed for S3 access.
        /// </summary>
        [JsonProperty(PropertyName = "roleArn")]
        public string RoleArn { get; set; }
        
        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public AwsCloudRegion CloudRegion { get; set; }
    }

}
