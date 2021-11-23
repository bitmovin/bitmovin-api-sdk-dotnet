using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AzureCloudRegion
    /// </summary>
    public enum AzureCloudRegion
    {
        /// <summary>
        /// Washington
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_EAST")]
        US_WEST2,

        /// <summary>
        /// Virginia
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_SOUTHEAST")]
        US_EAST,

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
        /// New South Wales
        /// </summary>
        [EnumMember(Value = "UAE_NORTH")]
        AUSTRALIA_EAST,

        /// <summary>
        /// Victoria
        /// </summary>
        [EnumMember(Value = "US_EAST")]
        AUSTRALIA_SOUTHEAST,

        /// <summary>
        /// Dubai
        /// </summary>
        [EnumMember(Value = "US_WEST2")]
        UAE_NORTH
    }
}
