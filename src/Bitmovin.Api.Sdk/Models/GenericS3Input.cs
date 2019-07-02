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
    /// GenericS3Input
    /// </summary>

    public class GenericS3Input : Input
    {
        /// <summary>
        /// Your generic S3 bucket name (required)
        /// </summary>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <summary>
        /// The generic S3 server hostname (or IP address) (required)
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// The port on which the generic S3 server is running on (if not provided 8000 will be used)
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        
        /// <summary>
        /// Controls whether SSL is used or not
        /// </summary>
        [JsonProperty(PropertyName = "ssl")]
        public bool? Ssl { get; set; }
        
        /// <summary>
        /// Specifies the method used for authentication
        /// </summary>
        [JsonProperty(PropertyName = "signatureVersion")]
        public S3SignatureVersion? SignatureVersion { get; set; }
        
        /// <summary>
        /// Your generic S3 access key (required)
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }
        
        /// <summary>
        /// Your generic S3 secret key (required)
        /// </summary>
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }
    }

}
