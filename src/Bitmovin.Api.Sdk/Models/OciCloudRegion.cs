using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// OciCloudRegion
    /// </summary>
    public enum OciCloudRegion
    {
        /// <summary>
        /// Frankfurt, Germany
        /// </summary>
        [EnumMember(Value = "EU_FRANKFURT_1")]
        EU_FRANKFURT_1,

        /// <summary>
        /// Ashburn, Virginia, USA
        /// </summary>
        [EnumMember(Value = "US_ASHBURN_1")]
        US_ASHBURN_1
    }
}
