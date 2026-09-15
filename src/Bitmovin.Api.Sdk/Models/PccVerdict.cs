using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
    /// </summary>
    public enum PccVerdict
    {
        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "played")]
        PLAYED,

        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "claimed-but-not-verified")]
        CLAIMED_BUT_NOT_VERIFIED,

        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "declares-no-support")]
        DECLARES_NO_SUPPORT,

        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "inconsistent-claim")]
        INCONSISTENT_CLAIM,

        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "inconclusive")]
        INCONCLUSIVE,

        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "unmeasured")]
        UNMEASURED,

        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "not-applicable")]
        NOT_APPLICABLE,

        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "infrastructure-fault")]
        INFRASTRUCTURE_FAULT,

        /// <summary>
        /// What a combination says once every session that measured it has been read. Five of the nine answer for the measurement rather than for the device; &#x60;aboutTheDevice&#x60; says which, and folding those into \&quot;not supported\&quot; is how this data gets misread.
        /// </summary>
        [EnumMember(Value = "never-reached")]
        NEVER_REACHED
    }
}
