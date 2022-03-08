using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SimpleEncodingLiveCloudRegion
    /// </summary>
    public enum SimpleEncodingLiveCloudRegion
    {
        /// <summary>
        /// The Live Encoding will be executed in the North America region
        /// </summary>
        [EnumMember(Value = "NORTH_AMERICA")]
        NORTH_AMERICA,

        /// <summary>
        /// The Live Encoding will be executed in the South America region
        /// </summary>
        [EnumMember(Value = "SOUTH_AMERICA")]
        SOUTH_AMERICA,

        /// <summary>
        /// The Live Encoding will be executed in the Europe region
        /// </summary>
        [EnumMember(Value = "EUROPE")]
        EUROPE,

        /// <summary>
        /// The Live Encoding will be executed in the Africa region
        /// </summary>
        [EnumMember(Value = "AFRICA")]
        AFRICA,

        /// <summary>
        /// The Live Encoding will be executed in the Asia region
        /// </summary>
        [EnumMember(Value = "ASIA")]
        ASIA,

        /// <summary>
        /// The Live Encoding will be executed in the Australia region
        /// </summary>
        [EnumMember(Value = "AUSTRALIA")]
        AUSTRALIA
    }
}
