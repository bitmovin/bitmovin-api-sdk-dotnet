using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AzureCloudRegion
    /// </summary>
    public enum AzureCloudRegion
    {
        /// <summary>
        /// New South Wales
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_EAST")]
        AUSTRALIA_EAST,

        /// <summary>
        /// Victoria
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_SOUTHEAST")]
        AUSTRALIA_SOUTHEAST,

        /// <summary>
        /// Ireland
        /// </summary>
        [EnumMember(Value = "EUROPE_NORTH")]
        EUROPE_NORTH,

        /// <summary>
        /// Netherlands
        /// </summary>
        [EnumMember(Value = "EUROPE_WEST")]
        EUROPE_WEST,

        /// <summary>
        /// Frankfurt
        /// </summary>
        [EnumMember(Value = "GERMANY_WESTCENTRAL")]
        GERMANY_WESTCENTRAL,

        /// <summary>
        /// Dubai
        /// </summary>
        [EnumMember(Value = "UAE_NORTH")]
        UAE_NORTH,

        /// <summary>
        /// Virginia
        /// </summary>
        [EnumMember(Value = "US_EAST")]
        US_EAST,

        /// <summary>
        /// Washington
        /// </summary>
        [EnumMember(Value = "US_WEST2")]
        US_WEST2
    }
}
