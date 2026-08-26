using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AdvisoryAnalysisStatus
    /// </summary>
    public enum AdvisoryAnalysisStatus
    {
        /// <summary>
        /// The shot was analysed for content advisories. An empty list of advisories means none were found
        /// </summary>
        [EnumMember(Value = "ANALYZED")]
        ANALYZED,

        /// <summary>
        /// The shot could not be analysed because the request was blocked by the model safety filter, so no verdict exists for it. Such a shot is reported conservatively rather than as clean: it carries a TOBACCO advisory with UNKNOWN confidence, which is an assumption made on the absence of a verdict and not an observation. Review these shots manually
        /// </summary>
        [EnumMember(Value = "BLOCKED")]
        BLOCKED
    }
}
