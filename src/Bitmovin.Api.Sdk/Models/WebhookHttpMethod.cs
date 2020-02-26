using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// WebhookHttpMethod
    /// </summary>
    public enum WebhookHttpMethod
    {
        /// <summary>
        /// POST
        /// </summary>
        [EnumMember(Value = "POST")]
        POST,

        /// <summary>
        /// PUT
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT
    }
}
