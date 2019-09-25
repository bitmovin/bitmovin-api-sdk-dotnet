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
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "S3_ROLE_BASED";

        /// <summary>
        /// Amazon S3 bucket name (required)
        /// </summary>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <summary>
        /// Amazon ARN of the IAM Role (Identity and Access Management Role) that will be assumed for S3 access.  This role has to be created by the owner of the account with the S3 bucket (i.e., you as a customer). For Bitmovin to be able to assume this role, the following has to be added to the trust policy of the role:  &#x60;&#x60;&#x60; {   \&quot;Effect\&quot;: \&quot;Allow\&quot;,   \&quot;Principal\&quot;: {     \&quot;AWS\&quot;: \&quot;arn:aws:iam::630681592166:user/bitmovinCustomerS3Access\&quot;   },   \&quot;Action\&quot;: \&quot;sts:AssumeRole\&quot;,   \&quot;Condition\&quot;: {     \&quot;StringEquals\&quot;: {       \&quot;sts:ExternalId\&quot;: \&quot;{{externalId}}\&quot;     }   } } &#x60;&#x60;&#x60;  where \&quot;arn:aws:iam::630681592166:user/bitmovinCustomerS3Access\&quot; is the Bitmovin user used for the access. The &#x60;Condition&#x60; is optional but we highly recommend it, see property &#x60;externalId&#x60; below for more information.  This setup allows Bitmovin assume the provided IAM role and to read data from your S3 bucket. Please note that the IAM role has to have read access on S3.  For more information about role creation please visit https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-service.html#roles-creatingrole-service-console (required)
        /// </summary>
        [JsonProperty(PropertyName = "roleArn")]
        public string RoleArn { get; set; }
        
        /// <summary>
        /// External ID used together with the IAM role identified by &#x60;roleArn&#x60; to assume S3 access.  This ID is generated once by the owner of the account with the S3 bucket (i.e., you as a customer) and added to the IAM role on AWS. Although it can be any string we recommend using a randomly generated UUID for better uniqueness. This ID then should be added to the trust policy of the IAM role &#x60;roleArn&#x60; configured above so that it looks something like this:  &#x60;&#x60;&#x60; {   \&quot;Effect\&quot;: \&quot;Allow\&quot;,   \&quot;Principal\&quot;: {     \&quot;AWS\&quot;: \&quot;arn:aws:iam::630681592166:user/bitmovinCustomerS3Access\&quot;   },   \&quot;Action\&quot;: \&quot;sts:AssumeRole\&quot;,   \&quot;Condition\&quot;: {     \&quot;StringEquals\&quot;: {       \&quot;sts:ExternalId\&quot;: \&quot;{{externalId}}\&quot;     }   } } &#x60;&#x60;&#x60;  where \&quot;{{externalId}}\&quot; is the generated ID.  This property is optional but we recommend it as an additional security feature. We will use both the &#x60;roleArn&#x60; and the &#x60;externalId&#x60; to access your S3 data. If the Amazon IAM role has an external ID configured but it is not provided in the input configuration Bitmovin won&#39;t be able to read from the S3 bucket. Also if the provided external ID does not match the one configured for the IAM role on AWS side, Bitmovin won&#39;t be able to access the S3 bucket.  You can change the external ID whenever you want, just update the trust policy of the IAM role and provide the new external ID in the input configuration. Note that we then won&#39;t be able to access your S3 buckets with the old external ID anymore, so you have to provide new input configuration.  For more information please visit https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html 
        /// </summary>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }
        
        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public AwsCloudRegion? CloudRegion { get; set; }
    }

}
