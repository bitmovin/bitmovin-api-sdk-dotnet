using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// HlsManifestAdMarkerSettings
    /// </summary>
    public class HlsManifestAdMarkerSettings
    {
        /// <summary>
        /// Ad marker types that will be inserted. More than one type is possible.  - EXT_X_CUE_OUT_IN: Ad markers will be inserted using &#x60;#EXT-X-CUE-OUT&#x60; and &#x60;#EXT-X-CUE-IN&#x60; tags - EXT_OATCLS_SCTE35: Ad markers will be inserted using &#x60;#EXT-OATCLS-SCTE35&#x60; tags. They contain the base64 encoded raw bytes of the original SCTE-35 trigger. - EXT_X_SPLICEPOINT_SCTE35: Ad markers will be inserted using &#x60;#EXT-X-SPLICEPOINT-SCTE35&#x60; tags. They contain the base64 encoded raw bytes of the original SCTE-35 trigger. - EXT_X_DATERANGE: Ad markers will be inserted using &#x60;#EXT-X-DATERANGE&#x60; tags. They contain the ID, start timestamp and hex encoded raw bytes of the original SCTE-35 trigger. - EXT_X_SCTE35: Ad markers will be inserted using &#x60;#EXT-X-SCTE35&#x60; tags. They contain the base64 encoded raw bytes of the original SCTE-35 trigger. 
        /// </summary>
        [JsonProperty(PropertyName = "enabledMarkerTypes")]
        public List<HlsManifestAdMarkerType> EnabledMarkerTypes { get; set; } = new List<HlsManifestAdMarkerType>();

        /// <summary>
        /// Certain tags, such as EXT_X_DATERANGE, may be preannounced in the HLS manifest. This means they are inserted as early as possible, before the actual ad break begins or ends. Preannouncing helps clients anticipate upcoming splice points, but may cause compatibility issues with some downstream consumers (e.g., AWS MediaTailor SSAI). When this setting is enabled, preannouncing of tags is disabled, and tags are inserted at the segment corresponding to the event&#39;s splice time. 
        /// </summary>
        [JsonProperty(PropertyName = "disablePreannouncing")]
        public bool? DisablePreannouncing { get; set; }
    }
}
