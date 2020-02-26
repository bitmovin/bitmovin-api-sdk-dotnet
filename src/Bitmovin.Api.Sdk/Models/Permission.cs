using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Permission to assign.
    /// </summary>
    public enum Permission
    {
        /// <summary>
        /// Permission to call http GET on the defined resource.
        /// </summary>
        [EnumMember(Value = "GET")]
        GET,

        /// <summary>
        /// Permission to call http DELETE on the defined resource.
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE,

        /// <summary>
        /// Permission to call http POST on the defined resource.
        /// </summary>
        [EnumMember(Value = "POST")]
        POST,

        /// <summary>
        /// Permission to call http PUT on the defined resource.
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT,

        /// <summary>
        /// Permission to call http PATCH on the defined resource.
        /// </summary>
        [EnumMember(Value = "PATCH")]
        PATCH
    }
}
