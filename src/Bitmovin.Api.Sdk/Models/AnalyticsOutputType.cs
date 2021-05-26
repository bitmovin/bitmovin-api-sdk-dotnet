using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AnalyticsOutputType
    /// </summary>
    public enum AnalyticsOutputType
    {
        /// <summary>
        /// S3_ROLE_BASED
        /// </summary>
        [EnumMember(Value = "S3_ROLE_BASED")]
        S3_ROLE_BASED,

        /// <summary>
        /// GCS_SERVICE_ACCOUNT
        /// </summary>
        [EnumMember(Value = "GCS_SERVICE_ACCOUNT")]
        GCS_SERVICE_ACCOUNT,

        /// <summary>
        /// AZURE
        /// </summary>
        [EnumMember(Value = "AZURE")]
        AZURE
    }
}
