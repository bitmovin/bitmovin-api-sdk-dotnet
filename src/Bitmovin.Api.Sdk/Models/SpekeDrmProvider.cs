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
    /// SpekeDrmProvider
    /// </summary>
    public class SpekeDrmProvider
    {
        /// <summary>
        /// URL of the endpoint (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Your username for Basic Authentication
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Your password for Basic Authentication
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// AWS role that will be assumed for the key exchange in case the provider runs on AWS.  During the key exchange the role will be assumed to be able to access the key provider.  This role has to be created by the owner of the account with the SPEKE server. For Bitmovin to be able to assume this role, the following has to be added to the trust policy of the role:  &#x60;&#x60;&#x60; {   \&quot;Effect\&quot;: \&quot;Allow\&quot;,   \&quot;Principal\&quot;: {     \&quot;AWS\&quot;: \&quot;arn:aws:iam::630681592166:user/bitmovinCustomerSpekeAccess\&quot;   },   \&quot;Action\&quot;: \&quot;sts:AssumeRole\&quot;,   \&quot;Condition\&quot;: {     \&quot;StringEquals\&quot;: {       \&quot;sts:ExternalId\&quot;: \&quot;{{externalId}}\&quot;     }   } } &#x60;&#x60;&#x60; It is recommended to also set the {{externalId}} due to security reasons but it can also be ommitted.  Additionally the role needs a policy similar to the following to be able to invoke the API gateway: &#x60;&#x60;&#x60; {   \&quot;Version\&quot;: \&quot;2012-10-17\&quot;,   \&quot;Statement\&quot;: [     {       \&quot;Effect\&quot;: \&quot;Allow\&quot;,       \&quot;Action\&quot;: [         \&quot;execute-api:Invoke\&quot;       ],       \&quot;Resource\&quot;: [         \&quot;arn:aws:execute-api:{{region}}:*:*_/_*_/POST/_*\&quot;       ]     }   ] } &#x60;&#x60;&#x60; where &#x60;{{region}}&#x60; is the region of the API gateway (for example &#x60;us-west-2&#x60;), the same has to be set in the property &#39;gatewayRegion&#39;. It&#39;s also possible to set &#x60;{{region}&#x60; to &#x60;*&#x60; to give the role access to all regions. 
        /// </summary>
        [JsonProperty(PropertyName = "roleArn")]
        public string RoleArn { get; set; }

        /// <summary>
        /// External ID used together with the IAM role identified by &#x60;roleArn&#x60; to assume access to the SPEKE server on AWS. 
        /// </summary>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// ExternalIdMode
        /// </summary>
        [JsonProperty(PropertyName = "externalIdMode")]
        public ExternalIdMode? ExternalIdMode { get; set; }

        /// <summary>
        /// Describes the region of the AWS API Gateway that is used to access the SPEKE server. This property is mandatory when setting &#39;roleArn&#39; and has to indicate in which region the AWS API Gateway is setup. This usually corresponds to the &#x60;{{region}}&#x60; one sets in the execute-api policy for the role as described in &#39;roleArn&#39;. 
        /// </summary>
        [JsonProperty(PropertyName = "gatewayRegion")]
        public string GatewayRegion { get; set; }
    }
}
