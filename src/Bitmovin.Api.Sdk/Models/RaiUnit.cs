using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Set the random access indicator (RAI) on appropriate access units (AUs).
    /// </summary>
    public enum RaiUnit
    {
        /// <summary>
        /// Never set RAI.
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// Set RAI in all PES packets.
        /// </summary>
        [EnumMember(Value = "ALL_PES_PACKETS")]
        ALL_PES_PACKETS,

        /// <summary>
        /// Set RAI if packet is marked acquisition point.
        /// </summary>
        [EnumMember(Value = "ACQUISITION_POINT_PACKETS")]
        ACQUISITION_POINT_PACKETS,

        /// <summary>
        /// Set RAI according to instructions in input file.
        /// </summary>
        [EnumMember(Value = "ACCORDING_TO_INPUT")]
        ACCORDING_TO_INPUT
    }
}
