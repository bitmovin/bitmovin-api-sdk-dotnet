using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// ExternalIdMode
    /// </summary>
    public enum ExternalIdMode
    {
        /// <summary>
        /// ExternalId can be provided by using the the &#x60;externalId&#x60; property. This way is not recommend by AWS (https://aws.amazon.com/blogs/security/how-to-use-external-id-when-granting-access-to-your-aws-resources/).
        /// </summary>
        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        /// <summary>
        /// The response will include an externalId that&#39;s unique and consistent for your organization
        /// </summary>
        [EnumMember(Value = "GLOBAL")]
        GLOBAL,

        /// <summary>
        /// The response will include a random externalId.
        /// </summary>
        [EnumMember(Value = "GENERATED")]
        GENERATED
    }
}
