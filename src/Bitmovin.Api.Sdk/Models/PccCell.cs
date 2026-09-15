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
    /// PccCell
    /// </summary>
    public class PccCell
    {
        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread. (required)
        /// </summary>
        [JsonProperty(PropertyName = "verdict")]
        public PccVerdict? Verdict { get; set; }

        /// <summary>
        /// The reader&#39;s word for that verdict — &#x60;Supported&#x60;, &#x60;Not supported&#x60;, &#x60;Not measured&#x60;, and so on. Fewer words than there are verdicts: three of them read as &#x60;Not measured&#x60;. &#x60;legend&#x60; lists every word. (required)
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// False where the verdict says something about the measurement rather than the device. (required)
        /// </summary>
        [JsonProperty(PropertyName = "aboutTheDevice")]
        public bool? AboutTheDevice { get; set; }

        /// <summary>
        /// The cell&#39;s whole account in one paragraph: the verdict, what agreed, the picture, the stream. (required)
        /// </summary>
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        /// <summary>
        /// The grid&#39;s own mark for that verdict, which &#x60;legend&#x60; explains. (required)
        /// </summary>
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// &#x60;3/4&#x60; where a session disagreed with the published verdict, and absent where none did.
        /// </summary>
        [JsonProperty(PropertyName = "agreement")]
        public string Agreement { get; set; }

        /// <summary>
        /// What the sessions that disagreed recorded, spelled out. Present only where &#x60;agreement&#x60; is.
        /// </summary>
        [JsonProperty(PropertyName = "agreementAccount")]
        public string AgreementAccount { get; set; }

        /// <summary>
        /// Picture
        /// </summary>
        [JsonProperty(PropertyName = "picture")]
        public PccPicture Picture { get; set; }

        /// <summary>
        /// The sessions this verdict was taken from. Quote one to Bitmovin support and the measurement behind this cell can be looked up, for as long as the fleet still holds it. (required)
        /// </summary>
        [JsonProperty(PropertyName = "agreeingSessionIds")]
        public List<string> AgreeingSessionIds { get; set; } = new List<string>();

        /// <summary>
        /// How many sessions recorded anything at all for this combination. (required)
        /// </summary>
        [JsonProperty(PropertyName = "resultSessions")]
        public decimal? ResultSessions { get; set; }

        /// <summary>
        /// Evidence excluded by the start date or session limit, including pools with no included sessions.
        /// </summary>
        [JsonProperty(PropertyName = "recency")]
        public string Recency { get; set; }
    }
}
