using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdMarkersSource
    /// </summary>
    public enum AdMarkersSource
    {
        /// <summary>
        /// MANIFEST
        /// </summary>
        [EnumMember(Value = "MANIFEST")]
        MANIFEST,

        /// <summary>
        /// SEGMENTS
        /// </summary>
        [EnumMember(Value = "SEGMENTS")]
        SEGMENTS
    }
}
