using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// HLS Manifest ad marker types
    /// </summary>
    public enum HlsManifestAdMarkerType
    {
        /// <summary>
        /// Ad markers will be inserted using &#x60;#EXT-X-CUE-OUT&#x60; and &#x60;#EXT-X-CUE-IN&#x60; tags
        /// </summary>
        [EnumMember(Value = "EXT_X_CUE_OUT_IN")]
        EXT_X_CUE_OUT_IN,

        /// <summary>
        /// Ad markers will be inserted using &#x60;#EXT-OATCLS-SCTE35&#x60; tags. They contain the base64 encoded raw bytes of the original SCTE-35 trigger.
        /// </summary>
        [EnumMember(Value = "EXT_OATCLS_SCTE35")]
        EXT_OATCLS_SCTE35,

        /// <summary>
        /// Ad markers will be inserted using &#x60;#EXT-X-SPLICEPOINT-SCTE35&#x60; tags. They contain the base64 encoded raw bytes of the original SCTE-35 trigger.
        /// </summary>
        [EnumMember(Value = "EXT_X_SPLICEPOINT_SCTE35")]
        EXT_X_SPLICEPOINT_SCTE35
    }
}
